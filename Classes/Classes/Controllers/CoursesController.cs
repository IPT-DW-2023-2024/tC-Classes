using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Classes.Data;
using Classes.Models;

namespace Classes.Controllers {
   public class CoursesController : Controller {
      private readonly ApplicationDbContext _context;

      public CoursesController(ApplicationDbContext context) {
         _context = context;
      }

      // GET: Courses
      public async Task<IActionResult> Index() {
         return View(await _context.Courses.ToListAsync());
      }

      // GET: Courses/Details/5
      public async Task<IActionResult> Details(int? id) {
         if (id == null) {
            return NotFound();
         }

         var courses = await _context.Courses
             .FirstOrDefaultAsync(m => m.Id == id);
         if (courses == null) {
            return NotFound();
         }

         return View(courses);
      }

      // GET: Courses/Create
      //   [HttpGet]   // you can specify this, but you don't need 
      public IActionResult Create() {
         return View();
      }

      // POST: Courses/Create
      // To protect from overposting attacks, enable the specific properties you want to bind to.
      // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
      [HttpPost]
      [ValidateAntiForgeryToken]
      public async Task<IActionResult> Create([Bind("Name")] Courses course , IFormFile LogoImage) {
         // the [Bind] annotation will protect your code for attacks

         // write the algorithm 
         // write the code


         if (ModelState.IsValid) {
            // if everything thar comes from VIEW is ok

            // add the Views' data to BD
            _context.Add(course);
            // Commit
            await _context.SaveChangesAsync();
            // redirect user to Index
            return RedirectToAction(nameof(Index));
         }

         // if the code arrive here, something wrong appens
         // returen to the VIEW with the data that View sent to Controller
         return View(course);
      }

      // GET: Courses/Edit/5
      public async Task<IActionResult> Edit(int? id) {
         if (id == null) {
            return NotFound();
         }

         var courses = await _context.Courses.FindAsync(id);
         if (courses == null) {
            return NotFound();
         }
         return View(courses);
      }

      // POST: Courses/Edit/5
      // To protect from overposting attacks, enable the specific properties you want to bind to.
      // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
      [HttpPost]
      [ValidateAntiForgeryToken]
      public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Logotype")] Courses courses) {
         if (id != courses.Id) {
            return NotFound();
         }

         if (ModelState.IsValid) {
            try {
               _context.Update(courses);
               await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) {
               if (!CoursesExists(courses.Id)) {
                  return NotFound();
               }
               else {
                  throw;
               }
            }
            return RedirectToAction(nameof(Index));
         }
         return View(courses);
      }

      // GET: Courses/Delete/5
      public async Task<IActionResult> Delete(int? id) {
         if (id == null) {
            return NotFound();
         }

         var courses = await _context.Courses
             .FirstOrDefaultAsync(m => m.Id == id);
         if (courses == null) {
            return NotFound();
         }

         return View(courses);
      }

      // POST: Courses/Delete/5
      [HttpPost, ActionName("Delete")]
      [ValidateAntiForgeryToken]
      public async Task<IActionResult> DeleteConfirmed(int id) {
         var courses = await _context.Courses.FindAsync(id);
         if (courses != null) {
            _context.Courses.Remove(courses);
         }

         await _context.SaveChangesAsync();
         return RedirectToAction(nameof(Index));
      }

      private bool CoursesExists(int id) {
         return _context.Courses.Any(e => e.Id == id);
      }
   }
}
