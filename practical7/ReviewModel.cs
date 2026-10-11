using System;

namespace CampusFeedbackHub.Models
{
    public class ReviewModel
    {
        public string StudentRegistrationNo { get; set; }
        public string FullName { get; set; }
        public string CourseTitle { get; set; }
        public int Stars { get; set; }
        public string FeedbackNotes { get; set; }
    }
}