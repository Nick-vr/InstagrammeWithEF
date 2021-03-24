using InstagrammeWithEF.Data.Repositories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InstagrammeWithEF.Tests
{
    public class UserTests
    {
        private UserRepo _repo;

        [SetUp]
        public void Setup()
        {
            _repo = new UserRepo();
        }

        // GetAllUsers
        [Test]
        public void TryToGetAllUsers()
        {
            // Arrange
            var users = _repo.GetAllUsers().Count();

            // Act

            // Assert
            Assert.AreEqual(100, users);
        }

        // Vind een user met al zijn posts
        [Test]
        public void FindAllPostsFromUser()
        {
            /*
             * SELECT * FROM Users
             * JOIN Posts ON Posts.UserId = Users.UserId
             * WHERE Users.UserId = 1
             */

            // Arrange
            const int userId = 1;

            // Act
            var user = _repo.FindUserWithPost(userId);

            // Assert
            Assert.IsNotNull(user);
        }

        // Zoek de 5 oudste profielen
        [Test]
        public void FindFiveOldestProfiles()
        {
            /*
             * SELECT TOP 5 Users.UserId, Users.UserName, Users.CreatedAt
             * FROM Users
             * ORDER BY Users.CreatedAt ASC
             */

            //arrange
            List<DateTime> users;
            List<DateTime> createdAtAllUsers;

            //act
            users = _repo.FindFiveOldestProfiles().Select(x => x.CreatedAt).ToList();
            createdAtAllUsers = _repo.GetAllUsers().OrderBy(x => x).Select(x => x.CreatedAt).Take(5).ToList();
            //assert
            Assert.AreSame(users, createdAtAllUsers);
        }

        // Zoek de profielen zonder fotos
        [Test]
        public void FindProfilesWithoutPhotos()
        {
            /*
             *  SELECT *
             *  FROM Users
             *  LEFT JOIN Posts ON Posts.UserId = Users.UserId
             *  WHERE Posts.ImageUrl is null
             */

            // Arrange

            // Act

            // Assert
        }

        // Geef alle posts die gepost werden door gebruikers die '...jan...' in hun username hebben
        [Test]
        public void GivePostsWithUserNamedLikeJan()
        {
            /*
             *  SELECT *
             *  FROM Posts
             *  JOIN Users ON Posts.UserId = Users.UserId
             *  WHERE Users.UserName LIKE '%jan%'
             */

            // Arrange

            // Act

            // Assert
        }

        // Vind de meest populaire foto en de persoon die deze gepost heeft
        [Test]
        public void GetMostPopularPhotoAndUserWhoPostedPhoto()
        {
            /*
             *
             * SELECT TOP 1 Posts.PostId
             * FROM Posts
             * JOIN Users ON Posts.UserId = Users.UserId
             */

            // Arrange

            // Act

            // Assert
        }

        // Zoek de datum waarop de meeste registraties plaatsvonden
        [Test]
        public void GetDateWithMostRegistrations()
        {
            // Arrange

            // Act

            // Assert
        }

        // Vind het gemiddeld aantal fotos per gebruiker
        [Test]
        public void GetAverageNumberOfPhotosByUser()
        {
            // Arrange

            // Act

            // Assert
        }

        // Zoek de 5 populairste hashtags

        [Test]
        public void GetFiveMostPopularHashtags()
        {
            // Arrange

            // Act

            // Assert
        }

        // de bots -> Gebruikers die elke foto liken
        [Test]
        public void GetUsersWhoLikeEveryPhoto()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}