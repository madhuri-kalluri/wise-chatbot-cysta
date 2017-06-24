using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CystaTLB.Models
{
    

        public class GenreItem
        {

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class books
        {

            private booksBook[] bookField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("book")]
            public booksBook[] book
            {
                get
                {
                    return this.bookField;
                }
                set
                {
                    this.bookField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class booksBook
        {

            private string titleField;

            private string authorField;

            private string isbnsField;

            private string book_linkField;

            private string review_snippetField;

            private System.DateTime review_dateField;

            private string review_publication_nameField;

            private string review_linkField;

            private string review_rating_imageField;

            private string review_publication_logoField;

            /// <remarks/>
            public string title
            {
                get
                {
                    return this.titleField;
                }
                set
                {
                    this.titleField = value;
                }
            }

            /// <remarks/>
            public string author
            {
                get
                {
                    return this.authorField;
                }
                set
                {
                    this.authorField = value;
                }
            }

            /// <remarks/>
            public string isbns
            {
                get
                {
                    return this.isbnsField;
                }
                set
                {
                    this.isbnsField = value;
                }
            }

            /// <remarks/>
            public string book_link
            {
                get
                {
                    return this.book_linkField;
                }
                set
                {
                    this.book_linkField = value;
                }
            }

            /// <remarks/>
            public string review_snippet
            {
                get
                {
                    return this.review_snippetField;
                }
                set
                {
                    this.review_snippetField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime review_date
            {
                get
                {
                    return this.review_dateField;
                }
                set
                {
                    this.review_dateField = value;
                }
            }

            /// <remarks/>
            public string review_publication_name
            {
                get
                {
                    return this.review_publication_nameField;
                }
                set
                {
                    this.review_publication_nameField = value;
                }
            }

            /// <remarks/>
            public string review_link
            {
                get
                {
                    return this.review_linkField;
                }
                set
                {
                    this.review_linkField = value;
                }
            }

            /// <remarks/>
            public string review_rating_image
            {
                get
                {
                    return this.review_rating_imageField;
                }
                set
                {
                    this.review_rating_imageField = value;
                }
            }

            /// <remarks/>
            public string review_publication_logo
            {
                get
                {
                    return this.review_publication_logoField;
                }
                set
                {
                    this.review_publication_logoField = value;
                }
            }
        }


    }

    }
