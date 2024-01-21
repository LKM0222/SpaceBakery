/*
    빵의 정보에 대한 클래스
    이름, 정보, 가격, 등급, 위치정보(이건 따로 미리 지정할거라 보류)
    빵의 모양, 재료 최대 갯수
*/

using System.Collections.Generic;

public class Bread{
    string breadCode;
    string breadName;
    string breadInfo;
    int price;
    int Rank;
    List<Ingredient> ingredients = new List<Ingredient>();
}