﻿namespace Contacts_Angular_App.Models.Domain
{
    public class Contact
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public required string Name { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string? Email { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>
        /// The phone.
        /// </value>
        public required string Phone { get; set; }

        /// <summary>
        /// Gets or sets the favorite.
        /// </summary>
        /// <value>
        /// The favorite.
        /// </value>
        public bool Favorite { get; set; }
    }
}