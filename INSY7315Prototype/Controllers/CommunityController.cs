using Microsoft.AspNetCore.Mvc;
using INSY7315Prototype.Models;

namespace INSY7315Prototype.Controllers
{
    public class CommunityController : Controller
    {
        // GET: /Community
        public IActionResult Index()
        {

            var viewModel = new CommunityPageViewModel
            {
                Alerts = new List<LostFoundAlert>
                {
                    new LostFoundAlert
                    {
                        Id = 1,
                        IsFound = false,
                        PetName = "Oliver",
                        StatusText = "Last seen in Oak Ridge",
                        TimeAgo = "Reported 2h ago",
                        PhotoUrl = "/images/catFour.jpeg"
                    },
                    new LostFoundAlert
                    {
                        Id = 2,
                        IsFound = true,
                        PetName = "Luna",
                        StatusText = "Safe at Sanctuary",
                        TimeAgo = "Checking for chip...",
                        PhotoUrl = "/images/catFive.jpeg"
                    }
                },
                Stories = new List<CommunityPost>
                {
                    new CommunityPost
                    {
                        Id = 1,
                        AuthorName = "Sarah Chen",
                        AuthorInitials = "SC",
                        PostedTimeAgo = "2 hours ago",
                        PhotoUrl = "/images/mochi.jpeg",
                        Caption = "Adopted Mochi today! He's already claiming the best spot on the sofa. Thank you Kingdom Cats Sanctuary!",
                        Tags = new List<string> { "#AdoptionSuccess", "#NewBeginnings" },
                        Comments = 8
                    },
                    new CommunityPost
                    {
                        Id = 2,
                        AuthorName = "James Patel",
                        AuthorInitials = "JP",
                        PostedTimeAgo = "5 hours ago",
                        PhotoUrl = "/images/zoomies.jpeg",
                        Caption = "Morning zoomies in full effect! This is what 6 AM looks like now.",
                        Tags = new List<string>(),
                        Comments = 4
                    }
                },
                FeaturedTip = new ExpertTip
                {
                    Badge = "Expert Tip",
                    Title = "Creating a 'Safe Room' for Your New Cat",
                    Excerpt = "When bringing a rescue home, start them in a small, quiet space with their bed, litter box, and food to prevent overwhelm...",
                    LinkText = "Read Full Guide",
                    Url = "#"
                },
                BlogArticles = new List<BlogArticle>
                {
                    new BlogArticle
                    {
                        Id = 1,
                        Category = "Adoption Guide",
                        ReadTime = "5 min read",
                        Title = "How to Cat-Proof Your Modern Home Without Sacrificing Style",
                        Excerpt = "Protect your furniture and keep your cat safe with these designer-approved tips for a harmonious living space.",
                        PhotoUrl = "/images/FavOne.jpeg",
                        Url = "#"
                    },
                    new BlogArticle
                    {
                        Id = 2,
                        Category = "Nutrition",
                        ReadTime = "8 min read",
                        Title = "Decoding the Label: What Your Cat Really Needs to Eat",
                        Excerpt = "Learn how to spot high-quality ingredients and avoid common fillers in commercial cat food brands.",
                        PhotoUrl = "/images/FavOne.jpeg",
                        Url = "#"
                    }
                }
            };

            return View(viewModel);
        }

        // POST: /Community/CreatePost
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePost(CreatePostRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.AuthorName) || string.IsNullOrWhiteSpace(request.Caption))
            {
                TempData["PostError"] = "Please add your name and a caption before posting.";
                return RedirectToAction("Index");
            }

            var tags = (request.TagsInput ?? string.Empty)
                .Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                .Select(t => t.StartsWith('#') ? t : $"#{t}")
                .ToList();

            var initials = string.Join("", request.AuthorName
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Take(2)
                .Select(n => char.ToUpper(n[0])));


            return RedirectToAction("Index");
        }
    }
}