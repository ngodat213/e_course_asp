using e_course_web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_course_web.Service.Helpers
{
    public static class PercentHelper
    {
        public static List<double> CalculateRatingPercent(IEnumerable<CourseFeedback> feedbacks)
        {
            List<double> ratingPercent = new List<double>(5) { 0, 0, 0, 0, 0 };

            int totalFeedbacks = feedbacks.Count();

            // Group feedbacks by rating and calculate the percentage
            var groupedFeedbacks = feedbacks.GroupBy(f => f.Rating);

            foreach (var group in groupedFeedbacks)
            {
                int ratingIndex = (int)group.Key - 1; // Ratings are 1-based
                double percentage = (double)group.Count() / totalFeedbacks * 100;

                ratingPercent[ratingIndex] = percentage;
            }

            return ratingPercent;
        }

        public static string ConvertRatingToStars(double rating)
        {
            int fullStars = (int)rating;
            int halfStars = (rating - fullStars >= 0.5) ? 1 : 0;
            int emptyStars = 5 - fullStars - halfStars;

            StringBuilder starsBuilder = new StringBuilder();

            for (int i = 0; i < fullStars; i++)
            {
                starsBuilder.Append("<i class=\"fas fa-star\"></i>");
            }

            if (halfStars == 1)
            {
                starsBuilder.Append("<i class=\"fas fa-star-half-alt\"></i>");
            }

            for (int i = 0; i < emptyStars; i++)
            {
                starsBuilder.Append("<i class=\"far fa-star\"></i>");
            }

            return starsBuilder.ToString();
        }
    }
}
