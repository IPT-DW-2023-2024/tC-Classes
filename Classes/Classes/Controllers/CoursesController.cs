﻿using System;
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

      /// <summary>
      /// Reference to the project DataBase
      /// </summary>
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
      [HttpGet]
      public IActionResult Create() {
         return View();
      }


      // POST: Courses/Create
      // To protect from overposting attacks, enable the specific properties you want to bind to.
      // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
      [HttpPost]
      [ValidateAntiForgeryToken]
      public async Task<IActionResult> Create([Bind("Name")] Courses course) {
         
         if (ModelState.IsValid) {

            // write here some code to accept file upload
            // then, to save it to server disk drive
            // and, add data (course name and file name) to database



            _context.Add(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
         }
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