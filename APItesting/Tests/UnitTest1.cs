using NUnit.Framework;
using RestSharp;
using APItesting.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace APItesting
{
    public class Tests
    {

        private RestClient _restClient;
        private RestRequest _restRequest;
        private RestResponse _restResponse;



        [SetUp]
        public void Setup()
        {

            _restClient = new RestClient();
            _restRequest = new RestRequest();
            _restResponse = new RestResponse();

            _restClient.BaseUrl = new Uri("http://localhost:3000");
            _restClient.AddDefaultHeader("Content-Type", "application/json");
        }

        [Test]
        public void CreateNewCar()
        {
            var newCar = new CarsModel() {Id = 1, Model = "Opel", Year = 1999, HorsePower = 150, Engine = 2 };
            var request = new RestRequest("/cars", Method.POST);
            request.AddParameter("application/json", newCar.ToJson(), ParameterType.RequestBody);
            IRestResponse response = _restClient.Execute(request);
            var actualCar = CarsModel.FromJson(response.Content);

            Assert.IsTrue(response.IsSuccessful);

            var expectedAuthor = new CarsModel()
            {
                Model = newCar.Model,
                Engine = newCar.Engine,
                Year = newCar.Year,

            };

            Assert.AreEqual(actualCar.Model, expectedAuthor.Model);
            Assert.AreEqual(actualCar.Year, expectedAuthor.Year);
        }
        [Test]
        public void ChekingForCorrectCarModelById()
        {
            var request = new RestRequest("/cars/1");
            var response = _restClient.Get(request);
            var currentCarModel = CarsModel.FromJson(response.Content);

            Assert.IsTrue(response.IsSuccessful);
            Assert.AreEqual("Ferrari", currentCarModel.Model);


        }
        [Test]
        public void DeleteExistingCarById()
        {
            var request = new RestRequest($"/cars/1", Method.DELETE);
            var response = _restClient.Execute(request);
            

        }
        [Test]
        public void PatchExistingCar()
        {
            var newCar = new CarsModel() { Model = "Porshe", Year = 2002, HorsePower = 533, Engine = 6 };
            var request = new RestRequest("/cars/1", Method.PATCH);
            request.AddParameter("application/json", newCar.ToJson(), ParameterType.RequestBody);
            IRestResponse response = _restClient.Execute(request);
            var actualCar = CarsModel.FromJson(response.Content);

            Assert.IsTrue(response.IsSuccessful);

            var expectedAuthor = new CarsModel()
            {
                Model = newCar.Model,
                Engine = newCar.Engine,
                Year = newCar.Year,

            };

            Assert.AreEqual(actualCar.Model, expectedAuthor.Model);
            Assert.AreEqual(actualCar.Year, expectedAuthor.Year);
        }
        [Test]
        public void CreateNewBook()
        {

            var newBook = new PostsModel() { Title = "Scrum Master" , Author = "Unknown" };
            var request = new RestRequest("/posts", Method.POST);
            request.AddParameter("application/json", newBook.ToJson(), ParameterType.RequestBody);
            IRestResponse response = _restClient.Execute(request);
            var actualBook = PostsModel.FromJson(response.Content);

            var expectedAuthor = new PostsModel()
            {
                Title = newBook.Title,
                Author = newBook.Author,
            };

            if (response != null && response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Assert.AreEqual(actualBook.Title, expectedAuthor.Title);
                Assert.AreEqual(actualBook.Author, expectedAuthor.Author);
            }  
            
            
        }





    }
}