using Microsoft.AspNetCore.Mvc;
using NotasApi.BusinessService;
using NotasApi.models;

namespace NotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReviewController : ControllerBase
    {
        private ReviewBusinessService _reviewBusinessService;
        public ReviewController(ReviewBusinessService reviewBusinessService)
        {
            _reviewBusinessService = reviewBusinessService;
        }

        // Get Reviews
        [HttpGet]
        public IEnumerable<Review> GetReviews()
        {
            return _reviewBusinessService.GetReviews();
        }

        //Get one Review
        [HttpGet("{id}")]
        public Review? GetReview(long id)
        {
            return _reviewBusinessService.GetReview(id);
        }

        //Insert Review
        [HttpPost]
        public Review InsertReview(Review review)
        {
            return _reviewBusinessService.InsertReview(review);
        }

        //Update Review
        [HttpPut]
        public Review? UpdateReview(Review review)
        {
            return _reviewBusinessService.UpdateReview(review);
        }

        //Delete Review
        [HttpDelete("{id}")]
        public bool DeleteReview(long id)
        {
            return _reviewBusinessService.DeleteReview(id);
        }
    }
}