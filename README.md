# Kingdom Cats Sanctuary

A website for Kingdom Cats Sanctuary, a small no-kill cat rescue, built as part of the **INSY7315 Work-Integrated Learning** module. Built by **ZenTech**.

The site gives the sanctuary a single online home for showcasing adoptable cats, managing adoption viewings and donations, promoting fundraising events, sharing merchandise, and connecting with the community — replacing what is currently an entirely manual, founder-run operation.

---

## Table of Contents

- [Features](#features)
- [Pages](#pages)
- [Admin Dashboard](#admin-dashboard)
- [Tech Stack](#tech-stack)
- [Design System](#design-system)
- [Getting Started](#getting-started)
- [Team](#team)

---

## Features

- **Cat profiles** — browse the sanctuary's residents, with photos, age, gender, and personality tags
- **Adoption booking** — book a viewing or a kitten petting session through a calendar and time-slot picker
- **Donations** — support the sanctuary via PayPal or Ozow
- **Events** — upcoming fundraisers and open days, filterable by cause and month
- **Community** — Lost & Found alerts, adopter stories, expert tips, and a blog, with comments and reactions
- **Merch** — browse sanctuary merchandise, with a click-to-flip product image
- **Accounts** — register and log in to manage bookings and donations
- **Multi-language and multi-currency selectors** in the navigation menu
- **Admin dashboard** — a single view for staff to review booking requests, event RSVPs, and donations, plus quick links to manage cats, events, merchandise, and community content

---

## Pages

| Route | Description |
|---|---|
| `/Home` | Hero, no-kill promise, featured cats, founders, reviews, contact info |
| `/Cats` | Browse all cats available for adoption |
| `/Bookings` | Book a viewing or petting session |
| `/Donations` | Donate to the sanctuary |
| `/Events` | Upcoming sanctuary events |
| `/Community` | Lost & Found, community stories, expert tips, blog |
| `/Merch` | Sanctuary merchandise |
| `/Account/Login` | Sign in / register |

---

## Admin Dashboard

`/Admin` gives sanctuary staff a single place to see what needs attention and jump to the tools they use most.

**Overview cards** show quick counts at a glance — total sanctuary cats, upcoming bookings, event RSVPs, donations received, and recent community posts.

**Booking requests** lists pending viewing and petting session requests with the visitor's details, session type, date, and time, with accept/reject actions for each.

**Event RSVPs** shows who has RSVP'd for upcoming events, including guest counts and status, with the ability to accept, reject, view details, or cancel a confirmed RSVP.

**Recent donations** lists the latest contributions with donor, amount, payment method, and status.

**Manage** links out to the existing Cats, Events, Merchandise, and Community pages for day-to-day content updates.

The accept/reject/cancel actions are currently mocked with confirm/alert dialogs in the view's JavaScript — wiring these to controller actions that update `Booking.Status`, `EventRsvp.Status`, and similar is the next step before this page is production-ready.

---

## Tech Stack

- **Backend:** ASP.NET Core MVC (C#, Razor views)
- **Database:** Azure SQL Database, via Entity Framework Core
- **File storage:** Azure Blob Storage (cat photos)
- **Frontend:** Tailwind CSS, vanilla JavaScript, Google Fonts (Playfair Display + Inter)
- **Hosting:** Azure App Service

---

## Design System

- **Colors:** cream background, off-white cards, deep red accent, near-black text, warm hairline borders
- **Fonts:** Playfair Display for headings, Inter for body text
- **Style:** warm, editorial, sanctuary-branded — consistent card layouts, filter pills, and accent panels reused across every page

---

## Getting Started

1. Clone the repository.
2. Set your Azure SQL connection string in `appsettings.json` (or user secrets).
3. Apply migrations:
   ```bash
   dotnet ef database update
   ```
4. Run the project:
   ```bash
   dotnet run
   ```

---

## Team

Built by **ZenTech** as part of the INSY7315 Work-Integrated Learning module (Information Systems 3E).
