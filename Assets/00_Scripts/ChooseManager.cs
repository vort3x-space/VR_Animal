using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseManager : MonoBehaviour
{
    [Header("Buttons")]
    public List<GameObject> buttonMember = new List<GameObject>();
    [Header("Animation")]
    public List<Animator> animationMember = new List<Animator>();
    [Header("Text")]
    public List<Text> textMember = new List<Text>();
    
    public void choose1()
    {
        buttonMember[0].SetActive(false);
        animationMember[0].SetTrigger("up");
        textMember[0].text = ("Fil, hortumlular takımının filgiller familyasını oluşturan memeli bir hayvandır. Geleneksel olarak Asya fili ve Afrika fili olmak üzere iki türü tanınır; ancak bazı kanıtlara dayanarak Afrika savan fili ile Afrika orman filinin de iki ayrı tür olduğu öne sürülür");
        StartCoroutine(waitSecond());
    }
    public void choose2()
    {
        buttonMember[1].SetActive(false);
        animationMember[1].SetTrigger("up");
        textMember[1].text = ("Deve, devegiller familyasının Camelus cinsini oluşturan iki evcil hayvan türünün ortak adı. Develer yük çeki ve binek hayvanı olarak kullanıldığı gibi, yünü, sütü, derisi ve eti için de beslenir. Yalnızca evcil türleriyle tanınan bu hayvanların yabanıl atalarından bu yana pek az değişikliğe uğradığı sanılmaktadır.");
        StartCoroutine(waitSecond());
    }
    public void choose3()
    {
        buttonMember[2].SetActive(false);
        animationMember[2].SetTrigger("up");
        textMember[2].text = ("Atlar, hayvanlar familyasından Equidae cinsine ait, boynuzlu, tüylü, otçul hayvanlardır. Atlar, insanlar tarafından yüzyıllardır arabalar, ekipman taşıma, spor ve eğlence için kullanılmıştır. Atlar, çok hızlı koşabilirler ve uzun mesafeler kat edebilirler. Atlar, ayrıca insanlar tarafından sağlık amacıyla terapi olarak kullanılır. Atlar, genellikle güzel ve cömert bir yapıya sahiptirler ve insanlar tarafından sevilirler.");
        StartCoroutine(waitSecond());
    }
    public void choose4()
    {
        buttonMember[3].SetActive(false);
        animationMember[3].SetTrigger("up");
        textMember[3].text = ("Sığır, memeliler sınıfının, çift toynaklılar takımının, boynuzlugiller familyasının sığırlar alt familyasından evcil büyükbaş hayvan. Çoğunlukla evcil olan, kaba ve hantal yapılı, kuyrukları püsküllü, boynuzlu büyükbaş hayvanlardır. Mideleri dört gözlüdür ve geviş getirirler. Üst çenelerinde kesici dişleri");
        StartCoroutine(waitSecond());
    }
    public void choose5()
    {
        buttonMember[4].SetActive(false);
        animationMember[4].SetTrigger("up");
        textMember[4].text = ("Koyun, Ovis cinsine bağlı bir memeli türüdür. Kuzey Amerika, Avrupa, Asya ve özellikle Afrika'da yayılmışlardır. Güney Amerika'ya ve Avustralya'ya insan eliyle ulaşmışlardır. Farklı biyotoplarda, özellikle steplerde, dağlık kesimlerde, az da olsa ormanlarda bulunurlar.");
        StartCoroutine(waitSecond());
    }

    public void choose6()
    {
        buttonMember[5].SetActive(false);
        animationMember[5].SetTrigger("up");
        textMember[5].text = ("Penguen, Sphenisciformes takımında Spheniscidae familyasında yer alan, uçamayan, dimdik durabilen, perde ayaklı deniz kuşlarıdır. Güney Kutbu, Yeni Zelanda, Avustralya, Güney Amerika, Güney Afrika ve Galapagos Adaları'nın kıyılarında yaşarlar; ancak Kuzey Kutbu da dahil olmak üzere Kuzey yarımkürede penguenler bulunmaz.");
        StartCoroutine(waitSecond());
    }
    public void choose7()
    {
        buttonMember[6].SetActive(false);
        animationMember[6].SetTrigger("up");
        textMember[6].text = ("Köpek; köpekgiller familyasına ait, görünüş ve büyüklükleri farklı 400'den fazla ırkı olan, etçil bir memelidir. Bozkurt'un alt türlerinden biri olan köpek, tilki ve çakallarla da yakın akrabalardır.");
        StartCoroutine(waitSecond());
    }
    public void choose8()
    {
        buttonMember[7].SetActive(false);
        animationMember[7].SetTrigger("up");
        textMember[7].text = ("Evcil kedi, küçük, genelde kıllı, evcilleştirilmiş, etobur memeli. Genelde ev hayvanı olarak beslenenlere ev kedisi, ya da diğer kedigillerden ve küçük kedilerden ayırmak gerekmiyorsa kısaca kedi denir. İnsanlar kedilerin arkadaşlığına ve haşarat ev zararlılarını avlayabilme yeteneğine önem vermektedir.");
        StartCoroutine(waitSecond());
    }
    public void choose9()
    {
        buttonMember[8].SetActive(false);
        animationMember[8].SetTrigger("up");
        textMember[8].text = ("Kaplumbağa, Testudines takımını oluşturan çok sert ve kemiksi bir kabuk içinde yaşayan, ağır yürüyüşlü, dört ayaklı, sürüngenler için kullanılan terim. Hareketleri yönünden ne kadar telaşsız ve ağır hayvanlarsa onların tarih boyunca gelişimi de o kadar yavaş olmuştur.");
        StartCoroutine(waitSecond());
    }
    public void choose10()
    {
        buttonMember[9].SetActive(false);
        animationMember[9].SetTrigger("up");
        textMember[9].text = ("Tavuk, sülüngiller familyasından evcilleştirilebilir bir kuş alt türüdür ve genelde çiftliklerde yetiştirilir. Hindistan'da Asya'nın güneydoğusundaki kırmızı Hint kuşundan geldiğine inanılır. 2003 yılında 24 milyar nüfus ile, dünyada en fazla bulunan kuş türüdür.");
        StartCoroutine(waitSecond());
    }

    IEnumerator waitSecond()
    {
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        yield return new WaitForSeconds(3f);
        textMember[0].text = ("");
        textMember[1].text = ("");
        textMember[2].text = ("");
        textMember[3].text = ("");
        textMember[4].text = ("");
        textMember[5].text = ("");
        textMember[6].text = ("");
        textMember[7].text = ("");
        textMember[8].text = ("");
        textMember[9].text = ("");
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }


}
