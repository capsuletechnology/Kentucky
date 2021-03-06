﻿using Kentucky.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Kentucky.Api
{
    public static class Api
    {
        #region GET
        #endregion

        #region INSERT
        public static async Task InsertUser(User user)
        {
            var _user = new User
            {                
                userFullName = user.userFullName,
                nickname = user.nickname,
                email = user.email,
                phone = user.phone,
                rating = 0,
                login = user.login
            };

            string jsonInput = JsonConvert.SerializeObject(_user);

            HttpContent contentPost = new StringContent(jsonInput, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var response = client.PostAsync("http://189.103.76.4:8080/WS_Manhattan/webresources/model.produto/", contentPost).Result;
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();
            }
        }

        public static async Task InsertPost(Post post, User user)
        {
            var _post = new Post
            {
                text = post.text,
                color = post.color,
                user = user,
                reports = new List<Report>(),
                likes = new List<Like>(),
                favorites = new List<Favorite>()
            };

            string jsonInput = JsonConvert.SerializeObject(_post);

            HttpContent contentPost = new StringContent(jsonInput, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var response = client.PostAsync("http://189.103.76.4:8080/WS_Manhattan/webresources/model.produto/", contentPost).Result;
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();
            }
        }

        public static async Task InsertReport(Report report)
        {
            string jsonInput = JsonConvert.SerializeObject(report);

            HttpContent contentPost = new StringContent(jsonInput, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var response = client.PostAsync("http://189.103.76.4:8080/WS_Manhattan/webresources/model.produto/", contentPost).Result;
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();
            }
        }

        public static async Task InsertLike(Like like)
        {
            string jsonInput = JsonConvert.SerializeObject(like);

            HttpContent contentPost = new StringContent(jsonInput, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var response = client.PostAsync("http://189.103.76.4:8080/WS_Manhattan/webresources/model.produto/", contentPost).Result;
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();
            }
        }

        public static async Task InsertFavorite(Favorite favorite)
        {
            string jsonInput = JsonConvert.SerializeObject(favorite);

            HttpContent contentPost = new StringContent(jsonInput, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var response = client.PostAsync("http://189.103.76.4:8080/WS_Manhattan/webresources/model.produto/", contentPost).Result;
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();
            }
        }
        #endregion

        #region UPDATE
        public static async Task UpdateUser(User user)
        {
            string jsonInput = JsonConvert.SerializeObject(user);

            HttpContent contentPost = new StringContent(jsonInput, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var response = client.PutAsync("http://189.103.76.4:8080/WS_Manhattan/webresources/model.cliente/" + user.userId, contentPost).Result;
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();
            }
        }

        public static async Task UpdatePost(Post post)
        {
            string jsonInput = JsonConvert.SerializeObject(post);

            HttpContent contentPost = new StringContent(jsonInput, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var response = client.PutAsync("http://189.103.76.4:8080/WS_Manhattan/webresources/model.cliente/", contentPost).Result;
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();
            }
        }
        #endregion

        #region DELETE
        #endregion
    }
}
