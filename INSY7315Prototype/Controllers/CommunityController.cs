using Microsoft.AspNetCore.Mvc;
using INSY7315Prototype.Models;

namespace INSY7315Prototype.Controllers
{
    public class CommunityController : Controller
    {
        // GET: /Community
        public IActionResult Index()
        {
            // TODO: replace with real data from your DbContext

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
                        PhotoUrl = "/images/FavTwo.jpeg"
                    },
                    new LostFoundAlert
                    {
                        Id = 2,
                        IsFound = true,
                        PetName = "Luna",
                        StatusText = "Safe at Sanctuary",
                        TimeAgo = "Checking for chip...",
                        PhotoUrl = "/images/catSeven.jpeg"
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
                        PhotoUrl = "/images/catFive.jpeg",
                        Caption = "Adopted Mochi today! He's already claiming the best spot on the sofa. Thank you Kingdom Cats Sanctuary!",
                        Tags = new List<string> { "#AdoptionSuccess", "#NewBeginnings" },
                        Likes = 24,
                        Dislikes = 1,
                        Comments = new List<PostComment>
                        {
                            new PostComment { Id = 1, PostId = 1, AuthorName = "Priya N.", Text = "He's gorgeous! Congrats on the new family member.", TimeAgo = "1 hour ago" },
                            new PostComment { Id = 2, PostId = 1, AuthorName = "Mark T.", Text = "That face! So happy for you both.", TimeAgo = "45 minutes ago" }
                        }
                    },
                    new CommunityPost
                    {
                        Id = 2,
                        AuthorName = "James Patel",
                        AuthorInitials = "JP",
                        PostedTimeAgo = "5 hours ago",
                        PhotoUrl = "/images/catFour.jpeg",
                        Caption = "Morning zoomies in full effect! This is what 6 AM looks like now.",
                        Tags = new List<string>(),
                        Likes = 41,
                        Dislikes = 0,
                        Comments = new List<PostComment>
                        {
                            new PostComment { Id = 3, PostId = 2, AuthorName = "Aisha K.", Text = "The zoomies are unstoppable at 6am, I feel this.", TimeAgo = "3 hours ago" }
                        }
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
                        PhotoUrl = "/images/catTen.jpeg",
                        Url = "#"
                    },
                    new BlogArticle
                    {
                        Id = 2,
                        Category = "Nutrition",
                        ReadTime = "8 min read",
                        Title = "Decoding the Label: What Your Cat Really Needs to Eat",
                        Excerpt = "Learn how to spot high-quality ingredients and avoid common fillers in commercial cat food brands.",
                        PhotoUrl = "/images/catNine.jpeg",
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

        // POST: /Community/AddComment
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddComment(AddCommentRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.AuthorName) || string.IsNullOrWhiteSpace(request.Text))
            {
                TempData["PostError"] = "Please add your name and a comment before posting.";
                return RedirectToAction("Index");
            }

          

            // Redirect back with the relevant post's comments panel open
            return Redirect(Url.Action("Index") + $"#comments-panel-{request.PostId}");
        }

        // POST: /Community/LikePost
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LikePost(VotePostRequest request)
        {

            return Redirect(Url.Action("Index") + $"#post-{request.PostId}");
        }

        // POST: /Community/DislikePost
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DislikePost(VotePostRequest request)
        {
            // TODO: replace with real persistence, same considerations as LikePost.

            return Redirect(Url.Action("Index") + $"#post-{request.PostId}");
        }
    }
}