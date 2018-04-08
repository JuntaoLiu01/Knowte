﻿using Knowte.PluginBase.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Knowte.PluginBase
{
    /// <summary>
    /// Implement this interface to create a plugin that is able to store notes in any alternative location.
    /// Instructions on how to write plugins, can be found in the file: "How to write plugins.md" in this project.
    /// </summary>
    public interface ICollectionProvider
    {
        /// <summary>
        /// Mandatory name for the provider
        /// </summary>
        string ProviderName { get; }

        /// <summary>
        /// Activates a collection based on collectionId
        /// </summary>
        /// <param name="collectionId">The collectionId</param>
        Task ActivateCollectionAsync(string collectionId);

        /// <summary>
        /// Get collectionId based on the collection title
        /// </summary>
        /// <param name="title">The collection title</param>
        /// <returns>The collectionId if the collection was found. An empty string if the collection was not found.</returns>
        Task<string> GetCollectionIdAsync(string title);

        /// <summary>
        /// Adds a collection based on its title
        /// </summary>
        /// <param name="title">The collection title</param>
        /// <param name="isActive">Indicates if the collection should be activate after adding</param>
        /// <returns>The collectionId if successful. An empty string if failure.</returns>
        Task<string> AddCollectionAsync(string title, bool isActive);

        /// <summary>
        /// Deletes a collection based on collectionId
        /// </summary>
        /// <param name="collectionId">The collectionId</param>
        Task DeleteCollectionAsync(string collectionId);

        /// <summary>
        /// Edits the title of a collection based on collectionId
        /// </summary>
        /// <param name="collectionId">The collectionId</param>
        /// <param name="title">The new title for the collection</param>
        Task EditCollectionAsync(string collectionId, string title);

        /// <summary>
        /// Gets all the collections
        /// </summary>
        /// <returns>A list of all collections</returns>
        Task<List<ICollection>> GetCollectionsAsync();

        /// <summary>
        /// Gets notebookId based on the notebook title
        /// </summary>
        /// <param name="title">The notebook title</param>
        /// <returns>The notebookId if the notebook was found. An empty string if the notebook was not found.</returns>
        Task<string> GetNotebookIdAsync(string title);

        /// <summary>
        /// Gets the id of the active collection
        /// </summary>
        /// <returns>The id of the active collection. An empty string if no collection is active.</returns>
        Task<string> GetActiveCollectionId();

        /// <summary>
        /// Adds a notebook based on its title
        /// </summary>
        /// <param name="title">The notebook title</param>
        /// <returns>The notebookId if successful. An empty string if failure.</returns>
        Task<string> AddNotebookAsync(string collectionId, string title);

        /// <summary>
        /// Edits the title of a notebook based on notebookId
        /// </summary>
        /// <param name="notebookId">The notebookId</param>
        /// <param name="title">The new title for the notebook</param>
        Task EditNotebookAsync(string notebookId, string title);

        /// <summary>
        /// Deletes a notebook based on notebookId
        /// </summary>
        /// <param name="notebookId">The notebookId</param>
        Task DeleteNotebookAsync(string notebookId);

        /// <summary>
        /// Gets all the notebooks for the given collectionId
        /// </summary>
        /// <returns>A list of all notebooks</returns>
        Task<List<INotebook>> GetNotebooksAsync(string collectionId);
    }
}