-- このluaスクリプトは、MA_01108_12.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera007 = SetTemplate("Actor007",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera008 = SetTemplate("Actor008",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01108_12_Flight")
-- ▲直接出力
-- ▼直接出力
load_image("still001", "content_still_10101018_image", "101010180_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101050011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor008")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(0.5)
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力

	--★★ヴェルナルス大将軍★★:順調すぎますな。ルーシャス様
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","MA_01108_120002")

	change_face(Actor004,"Sad")

	--★★皇帝ルーシャス★★:敵は我らローマに恐れをなした…と<br>大口を叩きたいところだが、これは違うな
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01108_120003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:バルバロイも少ない…<br>カレドニア本城にまわされているのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_120004")


	--★★皇帝ルーシャス★★:カレドニアはとっくに<br>バルバロイに呑まれ切ったと思っていたが…
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01108_120005")


	--★★ギネヴィア★★:因子量の少ない人間は<br>バルバロイの捕食対象になりにくいけど
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_120006")


	--★★ギネヴィア★★:だからといって狙われないわけじゃない
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_120007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ヴェルナルス大将軍★★:そのあたりの均衡は<br>魔女が取っているとみてよいだろう
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","MA_01108_120008")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ヴェルナルス大将軍★★:つまり魔女を始めとしたバルバロイの主戦力は<br>こちら側にはいない…あるいは──
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","MA_01108_120009")

-- ▼直接出力
DontChangeRandomCamera(true)
on_camera(RndCamera004)
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★皇帝ルーシャス★★:ふむ…どちらにせよ目的地までは目と鼻の先<br>しばしの休憩ののち、攻勢に出るとしよう
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01108_120010")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor004)
Hide(Actor003)
Hide(Actor005)
Hide(Actor006)
Hide(Actor007)
Hide(Actor008)
-- ▲直接出力
-- ▼直接出力
on_camera(RndCamera002)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
 --波の音入れてもいい
wait_time(2.2)
-- ▲直接出力
-- ▼直接出力
 --スチル表示
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
show_image("still001", 0.0, 0.0, 1.0, true, false)
-- ▲直接出力
-- ▼直接出力
wait_time(1.8)
-- ▲直接出力

	--★★ギネヴィア★★:海の向こうに行ったことは？
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","L","MA_01108_120012")


	--★★ノワール★★:…いや<br>ギネヴィアは？
	Talk(Actor001,"CHRNAME_NOIR","simple","L","MA_01108_120013")


	--★★ギネヴィア★★:わたしもまだ
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","L","MA_01108_120014")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:でもいつかね、ぜんぶ見てみたいの<br>いろんな所に旅したいの
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","L","MA_01108_120015")

	change_face(Actor001,"Smile")

	--★★ノワール★★:バルバロイがいなくなれば<br>いつでも遠くへ行けるよ
	Talk(Actor001,"CHRNAME_NOIR","simple","L","MA_01108_120016")

-- ▼直接出力
on_camera(RndCamera005)
-- ▲直接出力

	--★★ギネヴィア★★:…あなたが学園に来てくれて良かった<br>こうして他愛もない話をいっぱいできるから
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","L","MA_01108_120017")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
hide_image(1.0)
-- ▲直接出力
-- ▼直接出力
wait_time(1.8)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:あなたは…本当に良かったの？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_120018")

	change_face(Actor001,"Normal")

	--★★ノワール★★:良かったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_120019")

-- ▼直接出力
on_camera(Camera002)
-- ▲直接出力

	--★★ギネヴィア★★:あの日わたしが学園に誘わなければ<br>…わたしたちと一緒にいなければ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_120020")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★ギネヴィア★★:今みたいに辛いことも<br>なかったかもしれないじゃない…？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_120021")

-- ▼直接出力
on_camera(Camera001)
-- ▲直接出力

	--★★ノワール★★:きっとギネヴィアに出会わなくても<br>辛いことは起きたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_120022")


	--★★ギネヴィア★★:でも…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_120023")


	--★★ノワール★★:立ち向かう方法すら知らないまま<br>やられていたと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_120024")

-- ▼直接出力
on_camera(RndCamera005)
-- ▲直接出力

	--★★ギネヴィア★★:迷惑してない？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_120025")

	change_face(Actor001,"Smile")

	--★★ノワール★★:感謝してる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_120026")

-- ▼直接出力
on_camera(RndCamera002)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:………そっか<br>じゃ、感謝のしるしにさぁ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_120027")


	--★★ギネヴィア★★:これからも一緒にいてね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_120028")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:友達としてだからね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_120029")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("still001", "content_still_10101018_image", "101010180_StillImage")
	InitializeLoad_Preload()
	load_duel_scene_preload(101050011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor008")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
