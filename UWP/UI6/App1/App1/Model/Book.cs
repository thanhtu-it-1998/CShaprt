using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Model
{
    public class Book
    {
        int intBookID;
        string strTitle, strAuthor, strCoverImage;

        public int IntBookID { get => intBookID; set => intBookID = value; }
        public string StrTitle { get => strTitle; set => strTitle = value; }
        public string StrAuthor { get => strAuthor; set => strAuthor = value; }
        public string StrCoverImage { get => strCoverImage; set => strCoverImage = value; }


    }
    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var objBooks = new List<Book>();

            objBooks.Add(new Book { IntBookID = 1, StrTitle = "Vulpate", StrAuthor = "Futurum", StrCoverImage = "Assets/StoreLogo.png" });
            objBooks.Add(new Book { IntBookID = 1, StrTitle = "Vulpate", StrAuthor = "Futurum", StrCoverImage = "Assets/StoreLogo.png" });
            objBooks.Add(new Book { IntBookID = 1, StrTitle = "Vulpate", StrAuthor = "Futurum", StrCoverImage = "Assets/StoreLogo.png" });
            objBooks.Add(new Book { IntBookID = 1, StrTitle = "Vulpate", StrAuthor = "Futurum", StrCoverImage = "Assets/StoreLogo.png" });
            objBooks.Add(new Book { IntBookID = 1, StrTitle = "Vulpate", StrAuthor = "Futurum", StrCoverImage = "Assets/StoreLogo.png" });
            objBooks.Add(new Book { IntBookID = 1, StrTitle = "Vulpate", StrAuthor = "Futurum", StrCoverImage = "Assets/StoreLogo.png" });
            objBooks.Add(new Book { IntBookID = 1, StrTitle = "Vulpate", StrAuthor = "Futurum", StrCoverImage = "Assets/StoreLogo.png" });
            objBooks.Add(new Book { IntBookID = 1, StrTitle = "Vulpate", StrAuthor = "Futurum", StrCoverImage = "Assets/StoreLogo.png" });
            objBooks.Add(new Book { IntBookID = 1, StrTitle = "Vulpate", StrAuthor = "Futurum", StrCoverImage = "Assets/StoreLogo.png" });
            objBooks.Add(new Book { IntBookID = 1, StrTitle = "Vulpate", StrAuthor = "Futurum", StrCoverImage = "Assets/StoreLogo.png" });
            objBooks.Add(new Book { IntBookID = 1, StrTitle = "Vulpate", StrAuthor = "Futurum", StrCoverImage = "Assets/StoreLogo.png" });
            objBooks.Add(new Book { IntBookID = 1, StrTitle = "Vulpate", StrAuthor = "Futurum", StrCoverImage = "Assets/StoreLogo.png" });
            objBooks.Add(new Book { IntBookID = 1, StrTitle = "Vulpate", StrAuthor = "Futurum", StrCoverImage = "Assets/StoreLogo.png" });
            objBooks.Add(new Book { IntBookID = 1, StrTitle = "Vulpate", StrAuthor = "Futurum", StrCoverImage = "Assets/StoreLogo.png" });
            objBooks.Add(new Book { IntBookID = 1, StrTitle = "Vulpate", StrAuthor = "Futurum", StrCoverImage = "Assets/StoreLogo.png" });
            objBooks.Add(new Book { IntBookID = 1, StrTitle = "Vulpate", StrAuthor = "Futurum", StrCoverImage = "Assets/StoreLogo.png" });

            return objBooks;
        }
    }
}
