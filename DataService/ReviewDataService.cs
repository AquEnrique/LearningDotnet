using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.models;

namespace NotasApi.DataService
{
    public class ReviewDataService
    {
        private Context _context;
        public ReviewDataService(Context context)
        {
            _context = context;
        }

        // Get Reviews
        public IEnumerable<Review> GetReviews()
        {
            return _context.Reviews.ToList();
        }

        //Get one review
        public Review? GetReview(long id)
        {
            var review = _context.Reviews.Find(id);
            return review;
        }

        //Insert Review
        public Review InsertReview(Review review)
        {
            _context.Reviews.Add(review);
            _context.SaveChanges();
            return review;
        }

        //Update review
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