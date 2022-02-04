﻿using Microsoft.AspNet.Identity;
using SpaceBlackMarket.Models.SpaceTravelerModels;
using SpaceBlackMarket.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpaceBlackMarketMVC.Controllers
{
    [Authorize]
    public class SpaceTravelerController : Controller
    {
        // GET: SpaceTraveler
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new SpaceTravelerProfileService(userId);
            var model = service.GetSpaceTravelers();

            return View(model);
        }

        // GET
        public ActionResult Create()
        {
            return View();
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SpaceTravelerCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateSpaceTravelerService();

            if (service.CreateSpaceTraveler(model)) 
            {
                TempData["SaveResult"] = "Space Traveler Created.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Space Traveler could not be created.");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = CreateSpaceTravelerService();
            var model = svc.GetSpaceTravelerById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateSpaceTravelerService();
            var detail = service.GetSpaceTravelerById(id);
            var model =
                new SpaceTravelerEdit
                {
                    SpaceTravelerProfileId = detail.SpaceTravelerProfileId,
                    TravelerAlias = detail.TravelerAlias,
                    Credits = detail.Credits,
                    WantedLevel = detail.WantedLevel,
                    WillingToCooperate = detail.WillingToCooperate
                };
            return View(model);
        }

        private SpaceTravelerProfileService CreateSpaceTravelerService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new SpaceTravelerProfileService(userId);
            return service;
        }

    }
}