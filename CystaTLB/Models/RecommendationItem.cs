using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CystaTLB.Models
{
    public class RecommendationItem
    {

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class GoodreadsResponse
        {

            private GoodreadsResponseRequest requestField;

            private GoodreadsResponseBook bookField;

            /// <remarks/>
            public GoodreadsResponseRequest Request
            {
                get
                {
                    return this.requestField;
                }
                set
                {
                    this.requestField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseBook book
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
        public partial class GoodreadsResponseRequest
        {

            private bool authenticationField;

            private string keyField;

            private string methodField;

            /// <remarks/>
            public bool authentication
            {
                get
                {
                    return this.authenticationField;
                }
                set
                {
                    this.authenticationField = value;
                }
            }

            /// <remarks/>
            public string key
            {
                get
                {
                    return this.keyField;
                }
                set
                {
                    this.keyField = value;
                }
            }

            /// <remarks/>
            public string method
            {
                get
                {
                    return this.methodField;
                }
                set
                {
                    this.methodField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBook
        {

            private ulong idField;

            private string titleField;

            private string isbnField;

            private string isbn13Field;

            private string asinField;

            private string kindle_asinField;

            private string marketplace_idField;

            private string country_codeField;

            private string image_urlField;

            private string small_image_urlField;

            private ulong publication_yearField;

            private byte publication_monthField;

            private byte publication_dayField;

            private string publisherField;

            private string language_codeField;

            private bool is_ebookField;

            private string descriptionField;

            private GoodreadsResponseBookWork workField;

            private decimal average_ratingField;

            private string num_pagesField;

            private string formatField;

            private string edition_informationField;

            private string ratings_countField;

            private string text_reviews_countField;

            private string urlField;

            private string linkField;

            private GoodreadsResponseBookAuthors authorsField;

            private string reviews_widgetField;

            private GoodreadsResponseBookShelf[] popular_shelvesField;

            private GoodreadsResponseBookBook_links book_linksField;

            private GoodreadsResponseBookBuy_link[] buy_linksField;

            private object series_worksField;

            private GoodreadsResponseBookPublic_document public_documentField;

            private GoodreadsResponseBookBook[] similar_booksField;

            /// <remarks/>
            public ulong id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

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
            public string isbn
            {
                get
                {
                    return this.isbnField;
                }
                set
                {
                    this.isbnField = value;
                }
            }

            /// <remarks/>
            public string isbn13
            {
                get
                {
                    return this.isbn13Field;
                }
                set
                {
                    this.isbn13Field = value;
                }
            }

            /// <remarks/>
            public string asin
            {
                get
                {
                    return this.asinField;
                }
                set
                {
                    this.asinField = value;
                }
            }

            /// <remarks/>
            public string kindle_asin
            {
                get
                {
                    return this.kindle_asinField;
                }
                set
                {
                    this.kindle_asinField = value;
                }
            }

            /// <remarks/>
            public string marketplace_id
            {
                get
                {
                    return this.marketplace_idField;
                }
                set
                {
                    this.marketplace_idField = value;
                }
            }

            /// <remarks/>
            public string country_code
            {
                get
                {
                    return this.country_codeField;
                }
                set
                {
                    this.country_codeField = value;
                }
            }

            /// <remarks/>
            public string image_url
            {
                get
                {
                    return this.image_urlField;
                }
                set
                {
                    this.image_urlField = value;
                }
            }

            /// <remarks/>
            public string small_image_url
            {
                get
                {
                    return this.small_image_urlField;
                }
                set
                {
                    this.small_image_urlField = value;
                }
            }

            /// <remarks/>
            public ulong publication_year
            {
                get
                {
                    return this.publication_yearField;
                }
                set
                {
                    this.publication_yearField = value;
                }
            }

            /// <remarks/>
            public byte publication_month
            {
                get
                {
                    return this.publication_monthField;
                }
                set
                {
                    this.publication_monthField = value;
                }
            }

            /// <remarks/>
            public byte publication_day
            {
                get
                {
                    return this.publication_dayField;
                }
                set
                {
                    this.publication_dayField = value;
                }
            }

            /// <remarks/>
            public string publisher
            {
                get
                {
                    return this.publisherField;
                }
                set
                {
                    this.publisherField = value;
                }
            }

            /// <remarks/>
            public string language_code
            {
                get
                {
                    return this.language_codeField;
                }
                set
                {
                    this.language_codeField = value;
                }
            }

            /// <remarks/>
            public bool is_ebook
            {
                get
                {
                    return this.is_ebookField;
                }
                set
                {
                    this.is_ebookField = value;
                }
            }

            /// <remarks/>
            public string description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseBookWork work
            {
                get
                {
                    return this.workField;
                }
                set
                {
                    this.workField = value;
                }
            }

            /// <remarks/>
            public decimal average_rating
            {
                get
                {
                    return this.average_ratingField;
                }
                set
                {
                    this.average_ratingField = value;
                }
            }

            /// <remarks/>
            public string num_pages
            {
                get
                {
                    return this.num_pagesField;
                }
                set
                {
                    this.num_pagesField = value;
                }
            }

            /// <remarks/>
            public string format
            {
                get
                {
                    return this.formatField;
                }
                set
                {
                    this.formatField = value;
                }
            }

            /// <remarks/>
            public string edition_information
            {
                get
                {
                    return this.edition_informationField;
                }
                set
                {
                    this.edition_informationField = value;
                }
            }

            /// <remarks/>
            public string ratings_count
            {
                get
                {
                    return this.ratings_countField;
                }
                set
                {
                    this.ratings_countField = value;
                }
            }

            /// <remarks/>
            public string text_reviews_count
            {
                get
                {
                    return this.text_reviews_countField;
                }
                set
                {
                    this.text_reviews_countField = value;
                }
            }

            /// <remarks/>
            public string url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }

            /// <remarks/>
            public string link
            {
                get
                {
                    return this.linkField;
                }
                set
                {
                    this.linkField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseBookAuthors authors
            {
                get
                {
                    return this.authorsField;
                }
                set
                {
                    this.authorsField = value;
                }
            }

            /// <remarks/>
            public string reviews_widget
            {
                get
                {
                    return this.reviews_widgetField;
                }
                set
                {
                    this.reviews_widgetField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("shelf", IsNullable = false)]
            public GoodreadsResponseBookShelf[] popular_shelves
            {
                get
                {
                    return this.popular_shelvesField;
                }
                set
                {
                    this.popular_shelvesField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseBookBook_links book_links
            {
                get
                {
                    return this.book_linksField;
                }
                set
                {
                    this.book_linksField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("buy_link", IsNullable = false)]
            public GoodreadsResponseBookBuy_link[] buy_links
            {
                get
                {
                    return this.buy_linksField;
                }
                set
                {
                    this.buy_linksField = value;
                }
            }

            /// <remarks/>
            public object series_works
            {
                get
                {
                    return this.series_worksField;
                }
                set
                {
                    this.series_worksField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseBookPublic_document public_document
            {
                get
                {
                    return this.public_documentField;
                }
                set
                {
                    this.public_documentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("book", IsNullable = false)]
            public GoodreadsResponseBookBook[] similar_books
            {
                get
                {
                    return this.similar_booksField;
                }
                set
                {
                    this.similar_booksField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookWork
        {

            private GoodreadsResponseBookWorkID idField;

            private GoodreadsResponseBookWorkBooks_count books_countField;

            private GoodreadsResponseBookWorkBest_book_id best_book_idField;

            private GoodreadsResponseBookWorkReviews_count reviews_countField;

            private GoodreadsResponseBookWorkRatings_sum ratings_sumField;

            private GoodreadsResponseBookWorkRatings_count ratings_countField;

            private GoodreadsResponseBookWorkText_reviews_count text_reviews_countField;

            private GoodreadsResponseBookWorkOriginal_publication_year original_publication_yearField;

            private GoodreadsResponseBookWorkOriginal_publication_month original_publication_monthField;

            private GoodreadsResponseBookWorkOriginal_publication_day original_publication_dayField;

            private string original_titleField;

            private GoodreadsResponseBookWorkOriginal_language_id original_language_idField;

            private string media_typeField;

            private string rating_distField;

            private GoodreadsResponseBookWorkDesc_user_id desc_user_idField;

            private GoodreadsResponseBookWorkDefault_chaptering_book_id default_chaptering_book_idField;

            private GoodreadsResponseBookWorkDefault_description_language_code default_description_language_codeField;

            /// <remarks/>
            public GoodreadsResponseBookWorkID id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseBookWorkBooks_count books_count
            {
                get
                {
                    return this.books_countField;
                }
                set
                {
                    this.books_countField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseBookWorkBest_book_id best_book_id
            {
                get
                {
                    return this.best_book_idField;
                }
                set
                {
                    this.best_book_idField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseBookWorkReviews_count reviews_count
            {
                get
                {
                    return this.reviews_countField;
                }
                set
                {
                    this.reviews_countField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseBookWorkRatings_sum ratings_sum
            {
                get
                {
                    return this.ratings_sumField;
                }
                set
                {
                    this.ratings_sumField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseBookWorkRatings_count ratings_count
            {
                get
                {
                    return this.ratings_countField;
                }
                set
                {
                    this.ratings_countField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseBookWorkText_reviews_count text_reviews_count
            {
                get
                {
                    return this.text_reviews_countField;
                }
                set
                {
                    this.text_reviews_countField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseBookWorkOriginal_publication_year original_publication_year
            {
                get
                {
                    return this.original_publication_yearField;
                }
                set
                {
                    this.original_publication_yearField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseBookWorkOriginal_publication_month original_publication_month
            {
                get
                {
                    return this.original_publication_monthField;
                }
                set
                {
                    this.original_publication_monthField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseBookWorkOriginal_publication_day original_publication_day
            {
                get
                {
                    return this.original_publication_dayField;
                }
                set
                {
                    this.original_publication_dayField = value;
                }
            }

            /// <remarks/>
            public string original_title
            {
                get
                {
                    return this.original_titleField;
                }
                set
                {
                    this.original_titleField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseBookWorkOriginal_language_id original_language_id
            {
                get
                {
                    return this.original_language_idField;
                }
                set
                {
                    this.original_language_idField = value;
                }
            }

            /// <remarks/>
            public string media_type
            {
                get
                {
                    return this.media_typeField;
                }
                set
                {
                    this.media_typeField = value;
                }
            }

            /// <remarks/>
            public string rating_dist
            {
                get
                {
                    return this.rating_distField;
                }
                set
                {
                    this.rating_distField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseBookWorkDesc_user_id desc_user_id
            {
                get
                {
                    return this.desc_user_idField;
                }
                set
                {
                    this.desc_user_idField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseBookWorkDefault_chaptering_book_id default_chaptering_book_id
            {
                get
                {
                    return this.default_chaptering_book_idField;
                }
                set
                {
                    this.default_chaptering_book_idField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseBookWorkDefault_description_language_code default_description_language_code
            {
                get
                {
                    return this.default_description_language_codeField;
                }
                set
                {
                    this.default_description_language_codeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookWorkID
        {

            private string typeField;

            private uint valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public uint Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookWorkBooks_count
        {

            private string typeField;

            private ulong valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public ulong Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookWorkBest_book_id
        {

            private string typeField;

            private ulong valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public ulong Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookWorkReviews_count
        {

            private string typeField;

            private uint valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public uint Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookWorkRatings_sum
        {

            private string typeField;

            private uint valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public uint Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookWorkRatings_count
        {

            private string typeField;

            private uint valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public uint Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookWorkText_reviews_count
        {

            private string typeField;

            private ulong valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public ulong Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookWorkOriginal_publication_year
        {

            private string typeField;

            private ulong valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public ulong Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookWorkOriginal_publication_month
        {

            private string typeField;

            private bool nilField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool nil
            {
                get
                {
                    return this.nilField;
                }
                set
                {
                    this.nilField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookWorkOriginal_publication_day
        {

            private string typeField;

            private bool nilField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool nil
            {
                get
                {
                    return this.nilField;
                }
                set
                {
                    this.nilField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookWorkOriginal_language_id
        {

            private string typeField;

            private bool nilField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool nil
            {
                get
                {
                    return this.nilField;
                }
                set
                {
                    this.nilField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookWorkDesc_user_id
        {

            private string typeField;

            private uint valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public uint Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookWorkDefault_chaptering_book_id
        {

            private string typeField;

            private uint valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public uint Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookWorkDefault_description_language_code
        {

            private bool nilField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool nil
            {
                get
                {
                    return this.nilField;
                }
                set
                {
                    this.nilField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookAuthors
        {

            private GoodreadsResponseBookAuthorsAuthor authorField;

            /// <remarks/>
            public GoodreadsResponseBookAuthorsAuthor author
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookAuthorsAuthor
        {

            private ulong idField;

            private string nameField;

            private object roleField;

            private GoodreadsResponseBookAuthorsAuthorImage_url image_urlField;

            private GoodreadsResponseBookAuthorsAuthorSmall_image_url small_image_urlField;

            private string linkField;

            private decimal average_ratingField;

            private uint ratings_countField;

            private uint text_reviews_countField;

            /// <remarks/>
            public ulong id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public object role
            {
                get
                {
                    return this.roleField;
                }
                set
                {
                    this.roleField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseBookAuthorsAuthorImage_url image_url
            {
                get
                {
                    return this.image_urlField;
                }
                set
                {
                    this.image_urlField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseBookAuthorsAuthorSmall_image_url small_image_url
            {
                get
                {
                    return this.small_image_urlField;
                }
                set
                {
                    this.small_image_urlField = value;
                }
            }

            /// <remarks/>
            public string link
            {
                get
                {
                    return this.linkField;
                }
                set
                {
                    this.linkField = value;
                }
            }

            /// <remarks/>
            public decimal average_rating
            {
                get
                {
                    return this.average_ratingField;
                }
                set
                {
                    this.average_ratingField = value;
                }
            }

            /// <remarks/>
            public uint ratings_count
            {
                get
                {
                    return this.ratings_countField;
                }
                set
                {
                    this.ratings_countField = value;
                }
            }

            /// <remarks/>
            public uint text_reviews_count
            {
                get
                {
                    return this.text_reviews_countField;
                }
                set
                {
                    this.text_reviews_countField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookAuthorsAuthorImage_url
        {

            private bool nophotoField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool nophoto
            {
                get
                {
                    return this.nophotoField;
                }
                set
                {
                    this.nophotoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookAuthorsAuthorSmall_image_url
        {

            private bool nophotoField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool nophoto
            {
                get
                {
                    return this.nophotoField;
                }
                set
                {
                    this.nophotoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookShelf
        {

            private string nameField;

            private uint countField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint count
            {
                get
                {
                    return this.countField;
                }
                set
                {
                    this.countField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookBook_links
        {

            private GoodreadsResponseBookBook_linksBook_link book_linkField;

            /// <remarks/>
            public GoodreadsResponseBookBook_linksBook_link book_link
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookBook_linksBook_link
        {

            private byte idField;

            private string nameField;

            private string linkField;

            /// <remarks/>
            public byte id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public string link
            {
                get
                {
                    return this.linkField;
                }
                set
                {
                    this.linkField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookBuy_link
        {

            private ulong idField;

            private string nameField;

            private string linkField;

            /// <remarks/>
            public ulong id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public string link
            {
                get
                {
                    return this.linkField;
                }
                set
                {
                    this.linkField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookPublic_document
        {

            private ushort idField;

            private string document_urlField;

            /// <remarks/>
            public ushort id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            public string document_url
            {
                get
                {
                    return this.document_urlField;
                }
                set
                {
                    this.document_urlField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookBook
        {

            private uint idField;

            private string titleField;

            private string title_without_seriesField;

            private string linkField;

            private string small_image_urlField;

            private string image_urlField;

            private string num_pagesField;

            private GoodreadsResponseBookBookWork workField;

            private string isbnField;

            private string isbn13Field;

            private decimal average_ratingField;

            private uint ratings_countField;

            private string publication_yearField;

            private string publication_monthField;

            private string publication_dayField;

            private GoodreadsResponseBookBookAuthors authorsField;

            /// <remarks/>
            public uint id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

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
            public string title_without_series
            {
                get
                {
                    return this.title_without_seriesField;
                }
                set
                {
                    this.title_without_seriesField = value;
                }
            }

            /// <remarks/>
            public string link
            {
                get
                {
                    return this.linkField;
                }
                set
                {
                    this.linkField = value;
                }
            }

            /// <remarks/>
            public string small_image_url
            {
                get
                {
                    return this.small_image_urlField;
                }
                set
                {
                    this.small_image_urlField = value;
                }
            }

            /// <remarks/>
            public string image_url
            {
                get
                {
                    return this.image_urlField;
                }
                set
                {
                    this.image_urlField = value;
                }
            }

            /// <remarks/>
            public string num_pages
            {
                get
                {
                    return this.num_pagesField;
                }
                set
                {
                    this.num_pagesField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseBookBookWork work
            {
                get
                {
                    return this.workField;
                }
                set
                {
                    this.workField = value;
                }
            }

            /// <remarks/>
            public string isbn
            {
                get
                {
                    return this.isbnField;
                }
                set
                {
                    this.isbnField = value;
                }
            }

            /// <remarks/>
            public string isbn13
            {
                get
                {
                    return this.isbn13Field;
                }
                set
                {
                    this.isbn13Field = value;
                }
            }

            /// <remarks/>
            public decimal average_rating
            {
                get
                {
                    return this.average_ratingField;
                }
                set
                {
                    this.average_ratingField = value;
                }
            }

            /// <remarks/>
            public uint ratings_count
            {
                get
                {
                    return this.ratings_countField;
                }
                set
                {
                    this.ratings_countField = value;
                }
            }

            /// <remarks/>
            public string publication_year
            {
                get
                {
                    return this.publication_yearField;
                }
                set
                {
                    this.publication_yearField = value;
                }
            }

            /// <remarks/>
            public string publication_month
            {
                get
                {
                    return this.publication_monthField;
                }
                set
                {
                    this.publication_monthField = value;
                }
            }

            /// <remarks/>
            public string publication_day
            {
                get
                {
                    return this.publication_dayField;
                }
                set
                {
                    this.publication_dayField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseBookBookAuthors authors
            {
                get
                {
                    return this.authorsField;
                }
                set
                {
                    this.authorsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookBookWork
        {

            private uint idField;

            /// <remarks/>
            public uint id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookBookAuthors
        {

            private GoodreadsResponseBookBookAuthorsAuthor authorField;

            /// <remarks/>
            public GoodreadsResponseBookBookAuthorsAuthor author
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseBookBookAuthorsAuthor
        {

            private uint idField;

            private string nameField;

            private string linkField;

            /// <remarks/>
            public uint id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public string link
            {
                get
                {
                    return this.linkField;
                }
                set
                {
                    this.linkField = value;
                }
            }
        }


    }
}
