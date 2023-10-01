﻿using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using MvcTraining.Models;
using MvcTraining.Resources;
using System;
using System.Collections.Generic;

namespace MvcTraining.Repositories.Recipe
{
    public class IngredientDao : IRepository<IngredientDto>
    {
        private readonly ConnectionStringModel _connection;

        public IngredientDao(IOptions<ConnectionStringModel> connection)
        {
            _connection=connection.Value;
        }
        public int Create(IngredientDto item,long recipeId)
        {
            int result = 0;
            try
            {
                using(var con=new SqlConnection(_connection.DbConnection))
                {
                    con.Open();
                    var cmd=con.CreateCommand();
                    cmd.CommandText = SqlResources.SaveIngredient;
                    cmd.Parameters.AddWithValue("@name", item.Name);
                    cmd.Parameters.AddWithValue("@quantity", item.Quantity);
                    cmd.Parameters.AddWithValue("@unit", item.Unit);
                    cmd.Parameters.AddWithValue("@recipeId", recipeId);

                    result = cmd.ExecuteNonQuery();
                }
            }catch(Exception ex)
            {
                var con = new SqlConnection(_connection.DbConnection);
                con.Open() ;
                var cmd= con.CreateCommand();
                cmd.CommandText = SqlResources.DeleteRecipe;
                cmd.Parameters.AddWithValue("@id", recipeId);
                cmd.ExecuteNonQuery();
                con.Close();
                throw new Exception(ex.Message);
            }
            return result;
        }

        public int Create(IngredientDto item)
        {
            throw new NotImplementedException();
        }

        public int Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public int DuplicateCreate(IngredientDto item)
        {
            throw new System.NotImplementedException();
        }

        public int DuplicateUpdate(IngredientDto item)
        {
            throw new System.NotImplementedException();
        }

        public int FilterListCount(string searchParam)
        {
            throw new System.NotImplementedException();
        }

        public List<IngredientDto> GetAll(string searchParam, string pagination)
        {
            throw new System.NotImplementedException();
        }

        public IngredientDto GetById(long id)
        {
            throw new System.NotImplementedException();
        }

        public int ListCount()
        {
            throw new System.NotImplementedException();
        }

        public int Update(IngredientDto item)
        {
            throw new System.NotImplementedException();
        }
    }
}
