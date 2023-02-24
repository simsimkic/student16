/***********************************************************************
 * Module:  SurveyController.cs
 * Purpose: Definition of the Class Controller.SurveyController
 ***********************************************************************/

using System;
using System.Collections.Generic;
using Service;
using Model.Upravnik;


namespace Controller
{
   public class SurveyController
   {


        private readonly SurveyService service;

        public SurveyController(SurveyService service)
        {
            this.service = service;
        }

        public IEnumerable<Survey> GetAll() => service.GetAll();



        public Model.Upravnik.Survey AddSurvey(Model.Upravnik.Survey survey) => service.AddSurvey(survey);



        public Model.Upravnik.Survey DeleteSurvey(Model.Upravnik.Survey survey) => service.DeleteSurvey(survey);

        public Model.Upravnik.Survey GetSurvey(String name, String surname) => service.GetSurvey(name,surname);




    }
}