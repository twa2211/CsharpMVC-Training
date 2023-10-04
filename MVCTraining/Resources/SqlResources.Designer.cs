﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcTraining.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SqlResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SqlResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MvcTraining.Resources.SqlResources", typeof(SqlResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select count(Blog_Id) as Blog_Count from Tbl_Blog where Is_Deleted = 0.
        /// </summary>
        internal static string BlogCount {
            get {
                return ResourceManager.GetString("BlogCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE Tbl_Blog SET
        ///  Is_Deleted=@IsDeleted WHERE Blog_Id=@BlogId;.
        /// </summary>
        internal static string DeleteBlogBySort {
            get {
                return ResourceManager.GetString("DeleteBlogBySort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to delete Tbl_Ingredient where recipe_id=@recipeId.
        /// </summary>
        internal static string DeleteIngredient {
            get {
                return ResourceManager.GetString("DeleteIngredient", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to delete Tbl_Recipe where id=@id;.
        /// </summary>
        internal static string DeleteRecipe {
            get {
                return ResourceManager.GetString("DeleteRecipe", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to update Tbl_Ingredient set is_deleted=@IsDeleted where id=@id.
        /// </summary>
        internal static string DeleteSortIngredient {
            get {
                return ResourceManager.GetString("DeleteSortIngredient", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select count(id) from Tbl_Ingredient where name=@name and id!=@id and recipe_id=@recipeId and is_deleted=0.
        /// </summary>
        internal static string DuplicateIngredientUpdate {
            get {
                return ResourceManager.GetString("DuplicateIngredientUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT COUNT(Tbl_Blog.Blog_Id) FROM Tbl_Blog WHERE Blog_Title=@BlogTitle AND Blog_Author=@BlogAuthor And Is_Deleted=@IsDeleted;.
        /// </summary>
        internal static string DuplicateName {
            get {
                return ResourceManager.GetString("DuplicateName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT COUNT(Tbl_Blog.Blog_Id) FROM Tbl_Blog WHERE Blog_Title=@BlogTitle AND Blog_Author=@BlogAuthor And Blog_Id!=@BlogId And Is_Deleted=@IsDeleted;.
        /// </summary>
        internal static string DuplicateUpdate {
            get {
                return ResourceManager.GetString("DuplicateUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select Blog_Id,Blog_Title,Blog_Author,Blog_Content from Tbl_Blog where Is_Deleted = 0.
        /// </summary>
        internal static string GetAllBlog {
            get {
                return ResourceManager.GetString("GetAllBlog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select id,title,descript,instruction,author,prepare_time,cooking_time,dish_image,category,created_date from Tbl_Recipe where is_deleted=0.
        /// </summary>
        internal static string GetAllRecipe {
            get {
                return ResourceManager.GetString("GetAllRecipe", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT Blog_Id
        ///      ,Blog_Title
        ///      ,Blog_Author
        ///      ,Blog_Content
        ///  FROM Tbl_Blog WHERE Blog_Id=@BlogId;.
        /// </summary>
        internal static string GetBlogById {
            get {
                return ResourceManager.GetString("GetBlogById", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select name,quantity,unit,recipe_id from Tbl_Ingredient where id=@id.
        /// </summary>
        internal static string GetIngredientById {
            get {
                return ResourceManager.GetString("GetIngredientById", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select id,name,quantity,unit from Tbl_Ingredient where recipe_id=@recipeId and is_deleted=0.
        /// </summary>
        internal static string GetIngredientsByRecipeId {
            get {
                return ResourceManager.GetString("GetIngredientsByRecipeId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select id,title,descript,instruction,prepare_time,cooking_time,author,created_date,category,dish_image from Tbl_Recipe where id=@id and is_deleted=0.
        /// </summary>
        internal static string GetRecipeById {
            get {
                return ResourceManager.GetString("GetRecipeById", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select count(id)  from Tbl_Recipe where is_deleted=0.
        /// </summary>
        internal static string RecipeCount {
            get {
                return ResourceManager.GetString("RecipeCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO Tbl_Blog (
        ///  Blog_Title,Blog_Author,Blog_Content,Is_Deleted)
        ///  VALUES (@BlogTitle,@BlogAuthor,@BlogContent,@IsDeleted);.
        /// </summary>
        internal static string SaveBlog {
            get {
                return ResourceManager.GetString("SaveBlog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to insert into Tbl_Ingredient(
        ///	name
        ///	,quantity
        ///	,unit,recipe_id
        ///) values (@name,@quantity,@unit,@recipeId).
        /// </summary>
        internal static string SaveIngredient {
            get {
                return ResourceManager.GetString("SaveIngredient", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to insert into Tbl_Recipe(	title,descript,instruction,prepare_time,cooking_time,author,created_date,modified_date,category,dish_image
        ///) output inserted.id values(@title,@descript,@instruction,@prepareTime,@cookingTime,@author,@createdDate,@modifiedDate,@category,@image).
        /// </summary>
        internal static string SaveRecipe {
            get {
                return ResourceManager.GetString("SaveRecipe", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE Tbl_Blog SET 
        ///  Blog_Title=@BlogTitle
        ///  ,Blog_Author=@BlogAuthor
        ///  ,Blog_Content=@BlogContent WHERE Blog_Id=@BlogId;.
        /// </summary>
        internal static string UpdateBlog {
            get {
                return ResourceManager.GetString("UpdateBlog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to update Tbl_Ingredient set name=@name,quantity=@quantity,unit=@unit where id=@id.
        /// </summary>
        internal static string UpdateIngredient {
            get {
                return ResourceManager.GetString("UpdateIngredient", resourceCulture);
            }
        }
    }
}
