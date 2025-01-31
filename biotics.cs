﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 응소실팀플
{
    public partial class biotics : Form
    {
        public biotics()
        {
            InitializeComponent();
        }

        private void cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ltbx.Items.Clear();

            string[] lst1 = { "10종 복합코팅윤산균 에이(A) [일동바이오사이언스(주)]", "7종 복합코팅유산균 [일동바이오사이언스(주)]", "9종 복합코팅유산균 [일동바이오사이언스(주)]",
                "ALBUTAREX [코스맥스바이오(주)]","LactoCran+ [주식회사 노바렉스]","MR-10 올인원맨 [(주)네이처텍]","N-아세틸글루코사민 [(주)창성]",
            "가바앤정 [주식회사 노바렉스]","가이스머슬 게이너 [(주)유유헬스케어]","가이스머슬 웨이 [(주)유유헬스케어]"};
            string[] lst2 = { "(구)츄어블오메가-3 [(주)서흥]", "100억 프로바이오틱스 [코스맥스엔비티(주)]", "10억 생유산균 키즈 [엠에스바이오텍(주)제2공장]","2455레드다이어트 [노비스바이오(주)]",
            "3-콤보 [코스맥스바이오(주)]","333 프로그램 홍삼정차 [주식회사 네추럴웨이]","36.5 다이어트 [(주)양생당]"};
            string[] lst3 = { "구스밸런스푸드 [주식회사 노바렉스]", "레이디피크노제놀 [네이처퓨어코리아(주)]", "바이오 유산균 면역플로스 [주식회사 노바렉스]",
            "바이오 장유산균 [주식회사 노바렉스]","비바이뮨 캡슐 [주식회사 제이비케이랩]","에버콜라겐시그니처앰플 [코스맥스바이오(주)]","원앤원양 [주식회사 동진제약]"
            ,"원앤원음 [주식회사 동진제약]","장유산균 [주식회사 노바렉스]","카테슬림 [주식회사 노바렉스]","코엔자임NatQ [네이처퓨어코리아(주)]", "튼튼닷컴 알로에 쾌변 [주식회사 노바렉스]"};
            string[] lst4 = { "HCA 슬림라인 [(주)유유헬스케어","라피노스 [한국바이오팜(주)]","명작애 홍삼365 [고려홍삼원(주)]","미오나 라피노스 [(주)네추럴에프앤피 음성공장]" };
            string[] lst5 = { "G7 혼합유산균 [풀무원건강생활(주)]", "고은다이어트슬림식이섬유 [(주)비오팜]", "골든볼 [에스케이내추럴팜(주)]",
                "굿모닝 쾌변 플러스 다이어트 [(주)오투바이오]","네오바디 클린팻파우더S [주식회사한미양행]","녹십초닥터센스진 [(주)녹십초알로에]","더리얼신바이오틱스 [코스맥스바이오(주)]",
            "데일리 프로바이오틱스 [풀무원건강생활(주)]"};
            string[] lst6 = { "100억 프로바이오틱스 [코스맥스엔비티(주)]", "V-바이오틱스 [콜마비앤에이치(주)푸디팜사업부문]", "굿락투유 키즈 프로바이오틱스 [엠에스바이오텍(주)]",
                "그린핏유산균[엠에스바이오텍(주)제2공장]","글로벌비겐 리케어칼슘 [포항바이오파크]","나이트슬림다이어트 [엠에스바이오텍(주)]","닥터 3세대 유산균 [엠에스바이오텍(주)제2공장]",
            };
            string[] lst7 = { "+발효홍삼진 [(주)네추럴에프앤피 2공장]", "11피엠(PM) 톡 라이트 [코스맥스바이오(주)]", "365뉴트리션멀티비타민앤미네랄 [동서바이오팜(주)]",
                "Enhanced Essential Progiotics(전량수출용) [(주)네추럴에프앤피 2공장]","G7혼합유산균 [풀무원건강생활(주)]","HerBalance(전량수출용) [(주)네추럴에프앤피 2공장]"
                ,"혈천포르테 [코스맥스바이오(주)]",
            "Mr-10 미스터플러스 [(주)서흥 오창공장]","STARMOR(전량수출용 [(주)팜크로스]","간엔다움 [주식회사 다움]"};
            string[] lst8 = { "35베리삼환프리미엄(전량수출용) [노비스바이오(주)]", "4년근인삼농축액15 [대동고려삼(주)]", "6년근 고려홍삼 골드스틱100 [농업회사법인(주)힐링팜]","건강한혈행 [(주)한국씨엔에스팜]",
            "6년근 고려홍삼정진액스틱 [바산 고려홍삼(주)]","6년근인삼농축액20 [대동고려삼(주)]","6년근발효홍삼본액 [(주)서흥 오창공장]"};
            string[] lst9 = { "+간건강 [코스맥스바이오(주)]", "0920 리얼 밀크씨슬 & 홍경천 [네이처퓨어코리아(주)]", "3초습관 플러스타민 종합영양제 [(주)팜크로스]",
            "6년근 면역홍삼사포닌캡슐정 [고려인삼연구(주)]","6년근 발효홍삼CK(씨케이) [(주)파낙스코리아]","6년근 홍삼스틱 힘내삼 [고려홍삼원(주)]"};
            string[] lst10 = { "0118 리얼 테아닌 스트레스 클린 [네이처퓨어코리아(주)","0920 리얼 밀크씨슬 & 홍경천 [네이처퓨어코리아(주)","24다이어트 데이 [(주)한국씨엔에스팜]"
            ,"BF-7 아인슈타인 [콜마비앤에이치(주)푸디팜사업부문]", "ENERGETIC TONIC(수출용) [(주)한국인삼공사]","FOHO-15 [(주)오투바이오","RG프러스정 [(주)한국씨엔에스팜]," ,
            "간건강 [(주)서흥]","간에 좋은 안국 밀크씨슬 [주식회사한미양행]","간엔밀크씨슬 [주시회사 다움]","간조은 [콜마비앤에이치(주)푸디팜사업부문"
            ,"간편한에센셜 [(주)한국씨엔에스팜]","간프로 [이성제약(주)]"};
            string[] lst11 = { "(수진)고려홍삼정 [(주)수진식품]", "+면역비책 발효홍삼 [(주)네추럴에프앤피]", "+발효홍삼진 [(주)네추럴에프앤피 2공장]",
                "+홍삼젤리 [코스맥스바이오(주)]","0225 리얼 히알루론산 워터밤 [네이처퓨어코리아(주)]","0920 리얼 킬크씨슬 & 홍경천 [네이처퓨어코리아(주)]","10대를 위한 기억력 업(UP)홍삼 [(주)건보]",
            "42.195km [(주)비티진]"};


            if (cmbx.SelectedIndex == 0) ltbx.Items.AddRange(lst1);
            if (cmbx.SelectedIndex == 1) ltbx.Items.AddRange(lst2);
            if (cmbx.SelectedIndex == 2) ltbx.Items.AddRange(lst3);
            if (cmbx.SelectedIndex == 3) ltbx.Items.AddRange(lst4);
            if (cmbx.SelectedIndex == 4) ltbx.Items.AddRange(lst5);
            if (cmbx.SelectedIndex == 5) ltbx.Items.AddRange(lst6);
            if (cmbx.SelectedIndex == 6) ltbx.Items.AddRange(lst7);
            if (cmbx.SelectedIndex == 7) ltbx.Items.AddRange(lst8);
            if (cmbx.SelectedIndex == 8) ltbx.Items.AddRange(lst9);
            if (cmbx.SelectedIndex == 9) ltbx.Items.AddRange(lst10);
            if (cmbx.SelectedIndex == 10) ltbx.Items.AddRange(lst11);
       }
    }
}
