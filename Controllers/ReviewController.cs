using Microsoft.AspNetCore.Mvc;
using NotasApi.models;

namespace NotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReviewController : ControllerBase
    {
        private Context _context;
        public ReviewController(Context context)
        {
            _context = context;
        }

        // Get Reviews
        [HttpGet]
        public IEnumerable<Review> GetReviews()
        {
            return _context.Reviews.ToList();
        }

        //Get one review
        [HttpGet("{id}")]
        public Review? GetReview(long id)
        {
            var review = _context.Reviews.Find(id);
            return review;
        }

        //Insert Review
        [HttpPost]
        public Review InsertReview(Review review)
        {
            _context.Reviews.Add(review);
            _context.SaveChanges();
            return review;
        }

        //Update review
        [HttpPut]
        public Review? UpdateReview(Review review)
        {
            var reviewDbo = _context.Reviews.Find(review.IdReview);

            if (reviewDbo == null) return null;

            reviewDbo.IdStudent = review.IdStudent;
            reviewDbo.TopicReview = review.TopicReview;
            reviewDbo.StartDate = review.StartDate;
            reviewDbo.EndDate = review.EndDate;
            reviewDbo.ReviewInterval = review.ReviewInterval;
            reviewDbo.Student = review.Student;
            reviewDbo.Evaluations = review.Evaluations;

            _context.SaveChanges();
            return reviewDbo;
        }

        //Delete review
        [HttpDelete("{id}")]
        public bool DeleteReview(long id)
        {
            var reviewDbo = _context.Reviews.Find(id);
            if (reviewDbo == null) return false;

            _context.Reviews.Remove(reviewDbo);
            _context.SaveChanges();
            return true;
        }

    }
}