using DataAccessLayer.entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    //public class LibrarianService : ILibrarianService
    //{
    //    private readonly ILibrarianRepository _librarianRepository;
    //    public LibrarianService(ILibrarianRepository librarianReposirory)
    //    {
    //        _librarianRepository = librarianReposirory;
    //    }


    //}
    public class LibrarianService : ILibrarianService

    {
        private readonly ILibrarianRepository _librarianRepository;
        public LibrarianService(ILibrarianRepository liprarianarepository)
        {
            _librarianRepository = liprarianarepository;
        }
        //public static    LibrarianRepository _librarianRepository;
        public LibrarianService(LibrarianRepository librarianReposirory)
        {
            _librarianRepository = librarianReposirory;
        }
        public List<Librarian> GetAll()
        {
            return _librarianRepository.GetAll();
        }

        public Librarian Getbyid(int id)
        {
            return _librarianRepository.GetLibrarianbyId(id);
        }
        public Librarian Add(Librarian librarian) 
        {
        return Add(librarian);

        }

 


    }
}
