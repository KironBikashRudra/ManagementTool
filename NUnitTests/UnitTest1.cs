using FluentAssertions;
using RestSharp;
using System.Net;

namespace NUnitTests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        ///  DB �ڑ����������ǂ����e�X�g
        /// </summary>
        [Test] 
        public void TestOpenConnection()
        {
            // Arrange
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MyTestDb;";

            // Act
            con.Open();

            // Assert
            NUnit.Framework.Assert.That(con.State == ConnectionState.Open);
        }


        /// <summary>
        /// DB �ڑ�������n�ɃN���[�Y�ł��邩�ǂ����e�X�g
        /// </summary>
        [Test] //Test Case 2
        public void TestCloseConnection()
        {
            // Arrange
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MyTestDb;";

            // Act
            con.Open();  //open the connection
            con.Close(); //close to test if the connection closes

            // Assert
            NUnit.Framework.Assert.That(con.State == ConnectionState.Closed);
        }

        /// <summary>
        /// Admin���X�V�ł��Ă��邩
        /// </summary>
        [Test]
        public void CanBeEditedBy_Admin_True()
        {
            // Arrange
            var acessHelper = new AccessHelper();

            // Act
            var result = AccessHelper.CanBeEditedBy(new User() {
                Id = "1",
                Name = "XXX",
                Role = (int)Common.UserRole.Admin
            });

            // Assert
            Assert.That(result, Is.True);
        }

        /// <summary>
        /// �}�l�W���[���X�V�ł��邩�ǂ���
        /// </summary>
        [Test]
        public void CanBeEditedBy_Manager_False()
        {
            // Arrange
            var acessHelper = new AccessHelper();

            // Act
            var result = AccessHelper.CanBeEditedBy(new User() {
                Id = "1",
                Name = "XXX",
                Role = (int)Common.UserRole.Manager
            }); ;

            // Assert
            Assert.That(result, Is.False);
        }

        /// <summary>
        /// �}�l�W���[���X�V�ł��邩�ǂ���
        /// </summary>
        [Test]
        public void CanBeEditedBy_Me_True()
        {
            // Arrange
            var acessHelper = new AccessHelper();

            // Act
            var result = AccessHelper.CanBeEditedBy(new User() {
                Id = "1",
                Name = "MyName",
                Role = (int)Common.UserRole.General
            });

            // Assert
            Assert.That(result, Is.True);
        }

        /// <summary>
        /// Api ���N�G�X�g�e�X�g
        /// </summary>
        [Test]
        public void TestAPIRequest_SearchBooks_OK()
        {
            // Arrange
            var baseUrl = "https://fakerestapi.azurewebsites.net/api/v1/Books";
            RestClient client = new RestClient(baseUrl);
            RestRequest restRequest = new RestRequest(baseUrl, Method.Get);

            // Act
            RestResponse restResponse = client.Execute(restRequest);

            // Assert
            restResponse.Should().NotBeNull();
            restResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        }

    }
}