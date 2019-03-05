using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HW_05._03._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            ex1();
            ex2();
        }

        static void ex1()
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "utf-8", null);

            XmlElement films = doc.CreateElement("Films");
            XmlAttribute list = doc.CreateAttribute("FilmName");
            list.InnerText = "Список фильмов";
            films.Attributes.Append(list);

            XmlElement name = doc.CreateElement("Film");
            name.InnerText = "Алита боевой ангел";
            XmlElement genre = doc.CreateElement("Genre");
            genre.InnerText = "Фантастика";
            XmlElement rating = doc.CreateElement("Rating");
            rating.InnerText = "7.2";
            XmlElement body = doc.CreateElement("body");
            body.InnerText = "Действие фильма происходит через 300 лет после Великой войны в XXVI веке. Доктор Идо находит останки женщины-киборга. После починки киборг ничего не помнит, но обнаруживает, что в состоянии пользоваться боевыми приемами киборгов. Начинаются поиски утерянных воспоминаний.";

            films.AppendChild(name);
            films.AppendChild(genre);
            films.AppendChild(rating);
            films.AppendChild(body);
            doc.AppendChild(films);
            doc.Save("films.xml");

            XmlElement name1 = doc.CreateElement("Film");
            name1.InnerText = "Зеленая книга";
            XmlElement genre1 = doc.CreateElement("Genre");
            genre1.InnerText = "Комедия/драма";
            XmlElement rating1 = doc.CreateElement("Rating");
            rating1.InnerText = "8.4";
            XmlElement body1 = doc.CreateElement("body");
            body1.InnerText = "1960-е годы. После закрытия нью-йоркского ночного клуба на ремонт вышибала Тони по прозвищу Болтун ищет подработку на пару месяцев. Как раз в это время Дон Ширли, утонченный светский лев, богатый и талантливый чернокожий музыкант, исполняющий классическую музыку, собирается в турне по южным штатам, где ещё сильны расистские убеждения и царит сегрегация. Он нанимает Тони в качестве водителя, телохранителя и человека, способного решать текущие проблемы. У этих двоих так мало общего, и эта поездка навсегда изменит жизнь обоих.";

            films.AppendChild(name1);
            films.AppendChild(genre1);
            films.AppendChild(rating1);
            films.AppendChild(body1);
            doc.AppendChild(films);
            doc.Save("films.xml");


            XmlElement name2 = doc.CreateElement("Film");
            name2.InnerText = "Побег из Шоушенка";
            XmlElement genre2 = doc.CreateElement("Genre");
            genre2.InnerText = "Драма";
            XmlElement rating2 = doc.CreateElement("Rating");
            rating2.InnerText = "9.1";
            XmlElement body2 = doc.CreateElement("body");
            body2.InnerText = "Бухгалтер Энди Дюфрейн обвинен в убийстве собственной жены и ее любовника. Оказавшись в тюрьме под названием Шоушенк, он сталкивается с жестокостью и беззаконием, царящими по обе стороны решетки. Каждый, кто попадает в эти стены, становится их рабом до конца жизни. Но Энди, обладающий живым умом и доброй душой, находит подход как к заключенным, так и к охранникам, добиваясь их особого к себе расположения.";

            films.AppendChild(name2);
            films.AppendChild(genre2);
            films.AppendChild(rating2);
            films.AppendChild(body2);
            doc.AppendChild(films);
            doc.Save("films.xml");


            XmlElement name3 = doc.CreateElement("Film");
            name3.InnerText = "Призрак в доспехах";
            XmlElement genre3 = doc.CreateElement("Genre");
            genre3.InnerText = "Аниме";
            XmlElement rating3 = doc.CreateElement("Rating");
            rating3.InnerText = "7.9";
            XmlElement body3 = doc.CreateElement("body");
            body3.InnerText = "2029 год. Границы между государствами окончательно рухнули, благодаря повсеместно распространившимся компьютерным сетям и кибер-технологиям. Когда давно разыскиваемый хакер по кличке Кукловод начинает вмешиваться в политику, 9-й Отдел Министерства Общественной безопасности, группа кибернетически модифицированных полицейских, получает задание найти и остановить хакера. Но в ходе расследования возникает вопрос: кто же такой Кукловод в том мире где грань между человеком и машиной практически стерта?";

            films.AppendChild(name3);
            films.AppendChild(genre3);
            films.AppendChild(rating3);
            films.AppendChild(body3);
            doc.AppendChild(films);
            doc.Save("films.xml");


            XmlElement name4 = doc.CreateElement("Film");
            name4.InnerText = "Настоящий детектив";
            XmlElement genre4 = doc.CreateElement("Genre");
            genre4.InnerText = "Детектив/Криминал";
            XmlElement rating4 = doc.CreateElement("Rating");
            rating4.InnerText = "8.7";
            XmlElement body4 = doc.CreateElement("body");
            body4.InnerText = "Первый сезон. В Луизиане в 1995 году происходит странное убийство девушки. В 2012 году дело об убийстве 1995г. повторно открывают, так как произошло похожее убийство. Дабы лучше продвинуться в расследовании, полиция решает допросить бывших детективов, которые работали над делом в 1995г.";

            films.AppendChild(name4);
            films.AppendChild(genre4);
            films.AppendChild(rating4);
            films.AppendChild(body4);
            doc.AppendChild(films);
            doc.Save("films.xml");
        }

        static void ex2()
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "windows-1251", "yes");

            XmlElement tovar = doc.CreateElement("TOVAR");
            XmlAttribute t1 = doc.CreateAttribute("tovar");
            t1.InnerText = "Список товаров";
            tovar.Attributes.Append(t1);

            XmlElement naim = doc.CreateElement("NAIM");
            naim.InnerText = "Бензин";
            XmlElement price = doc.CreateElement("PRICE");
            price.InnerText = "20";

            tovar.AppendChild(naim);
            tovar.AppendChild(price);

            doc.AppendChild(tovar);
            doc.Save("1.xml");

        }
    }
}
