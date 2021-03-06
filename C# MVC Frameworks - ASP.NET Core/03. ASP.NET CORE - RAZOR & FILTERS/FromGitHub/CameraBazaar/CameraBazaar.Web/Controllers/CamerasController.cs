﻿namespace CameraBazaar.Web.Controllers
{
    using System.Linq;
    using CameraBazaar.Data.Models;
    using CameraBazaar.Services.Contracts;
    using CameraBazaar.Web.Models.Cameras;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class CamerasController : Controller
    {
        private readonly ICameraService cameras;
        private readonly UserManager<User> userManager;

        public CamerasController(ICameraService cameras, UserManager<User> userManager)
        {
            this.cameras = cameras;
            this.userManager = userManager;
        }

        [Authorize]
        public IActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(CameraFormModel cameraModel)
        {
            if (!ModelState.IsValid)
            {
                return this.View(cameraModel);
            }

            this.cameras.Create(
                cameraModel.Make,
                cameraModel.Model,
                cameraModel.Price,
                cameraModel.Quantity,
                cameraModel.MinShutterSpeed,
                cameraModel.MinShutterSpeed,
                cameraModel.MinIso,
                cameraModel.MaxIso,
                cameraModel.IsFullFrame,
                cameraModel.VideoResolution,
                cameraModel.LightMeterings,
                cameraModel.Description,
                cameraModel.ImageUrl,
                this.userManager.GetUserId(this.User));

            return this.RedirectToAction(nameof(HomeController.Index), "Home");
        }

        public IActionResult All()
        {
            var cameras = this.cameras.All();

            return this.View(cameras);
        }

        public IActionResult FullDetail(int id)
        {
            var camera = this.cameras.GetCameraById(id);

            return this.View(camera);
        }

        [Authorize]
        public IActionResult Edit(int id)
        {
            var cameraExists = this.cameras.CameraExists(id, this.userManager.GetUserId(User));

            if (!cameraExists)
            {
                return NotFound();
            }

            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(int id, CameraFormModel cameraModel)
        {
            var editCamera = this.cameras.Edit(
                id,
                cameraModel.Make,
                cameraModel.Model,
                cameraModel.Price,
                cameraModel.Quantity,
                cameraModel.MinShutterSpeed,
                cameraModel.MinShutterSpeed,
                cameraModel.MinIso,
                cameraModel.MaxIso,
                cameraModel.IsFullFrame,
                cameraModel.VideoResolution,
                cameraModel.LightMeterings,
                cameraModel.Description,
                cameraModel.ImageUrl,
                this.userManager.GetUserId(this.User));

            if (!editCamera)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(All));
        }
    }
}