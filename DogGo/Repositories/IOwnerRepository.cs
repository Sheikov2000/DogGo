using DogGo.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    public interface IOwnerRepository
    {
        List<Owner> GetAllOwners();
        Owner GetOwnerById(int id);
        Owner AddOwner(int id);
        Owner UpdateOwner(int id);
        Owner DeleteOwner(int id);


    }

   
}