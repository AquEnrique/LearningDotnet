using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.DataService;
using NotasApi.models;

namespace NotasApi.BusinessService
{
    public class ReviewBusinessService
    {
        private ReviewDataService _reviewDataService;
        public ReviewBusinessService(ReviewDataService reviewDataService)
        {
            _reviewDataService = reviewDataService;
        }

        // Get Reviews
        public IEnumerable<Review> GetReviews()
        {
            return _reviewDataService.GetReviews();
        }

        //Get one Review
        public Review? GetReview(long id)
        {
            return _reviewDataService.GetReview(id);
        }

        //Insert Review
        public Review InsertReview(Review review)
        {
            return _reviewDataService.InsertReview(review);
        }

        //Update Review
        public Review? UpdateReview(Review review)
        {
            return _reviewDataService.UpdateReview(review);
        }

        //Delete Review
        public bool DeleteReview(long id)
        {
            return _reviewDataService.DeleteReview(id);
        }
    }
}