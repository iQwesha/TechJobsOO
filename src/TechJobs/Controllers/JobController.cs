﻿using Microsoft.AspNetCore.Mvc;
using TechJobs.Data;
using TechJobs.ViewModels;

namespace TechJobs.Controllers
{
    public class JobController : Controller
    {

        // Our reference to the data store
        private static JobData jobData;

        static JobController()
        {
            jobData = JobData.GetInstance();
        }

        // The detail display for a given Job at URLs like /Job?id=17
        public IActionResult Index(int id)
        {
            ViewBag.someJob = jobData.FindByValue();
            // TODO #1 - get the Job with the given ID and pass it into the view

            JobFieldsViewModel jobFieldsViewModel = new JobFieldsViewModel();
            jobFieldsViewModel.Title = "View Job Fields";

            return View(jobFieldsViewModel);

        }

        public IActionResult New()
        {
            NewJobViewModel newJobViewModel = new NewJobViewModel();
            return View(newJobViewModel);
        }

        [HttpPost]
        public IActionResult New(NewJobViewModel newJobViewModel)
        {
            // TODO #6 - Validate the ViewModel and if valid, create a 
            // new Job and add it to the JobData data store. Then
            // redirect to the Job detail (Index) action/view for the new Job.

            return View(newJobViewModel);
        }
    }
}
