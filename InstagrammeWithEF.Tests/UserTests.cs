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
             *  SELECT TOP 1 Likes.PostID, USERS.UserId, USERS.UserName, COUNT(Likes.PostID) AS 'aantal likes'
             *  FROM Likes
             *  LEFT JOIN Posts ON Likes.PostID = Posts.PostID
             *  LEFT JOIN Users ON Posts.UserId = Users.UserId
             *  GROUP BY Likes.PostID, Users.UserId, Users.UserName
             *  ORDER BY COUNT(Likes.PostID) DESC
             */

            // Arrange

            // Act

            // Assert
        }

        // Zoek de datum waarop de meeste registraties plaatsvonden
        [Test]
        public void GetDateWithMostRegistrations()
        {
            /*
             *  SELECT TOP 1 Users.CreatedAt, COUNT(Users.CreatedAt) AS 'Most Regs'
             *  FROM Users
             *  GROUP BY Users.CreatedAt
             *  ORDER BY COUNT(Users.CreatedAt) DESC
             */

            // Arrange

            // Act

            // Assert
        }

        // Vind het gemiddeld aantal fotos per gebruiker
        [Test]
        public void GetAverageNumberOfPhotosByUser()
        {
            /* SELECT ROUND( ((SELECT Count(*) FROM   Posts) +0.0) / (SELECT Count(*) FROM   users) , 2) AS avg; */

            // Arrange

            // Act

            // Assert
        }

        // Zoek de 5 populairste hashtags

        [Test]
        public void GetFiveMostPopularHashtags()
        {
            /*
             *  SELECT TOP 5 Tags.TagName, Tags.TagId, COUNT(*) AS r
             *  FROM Tags
             *  LEFT JOIN PostTags
             *  ON Tags.TagId = PostTags.TagId
             *  GROUP BY Tags.TagName, Tags.TagId
             *  ORDER BY r DESC
             */

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