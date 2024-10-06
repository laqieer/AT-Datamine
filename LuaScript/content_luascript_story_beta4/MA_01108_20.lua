-- このluaスクリプトは、MA_01108_20.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("still001", "content_still_10101019_image", "101010190_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101050011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor004")
	template1()
end

function Play()
	StartPlay()

	change_face(Actor003,"Sad")

	--★★ガレス★★:海に出ちゃったね～
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01108_200002")


	--★★リオネス★★:ブライアンさんがアストラット郷で数日休んで<br>北に向かったらしいことは聞いたけど…
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","MA_01108_200003")

	PlayAction(Actor003,"to  Std_Worry")

	--★★ガレス★★:北へ進み続けてたら<br>海に出ちゃった～♪
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01108_200005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★ディナタン★★:ブライアンさん…<br>どこに向かっているんだろう
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01108_200006")


	--★★ガレス★★:海を見たかったのかな～？
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01108_200008")


	--★★ノワール★★:目的地がカレドニアだとしても<br>ブライアンは魔女のことを嫌ってた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_200009")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:ライエンスの言いようだと<br>ブライアンを好意的に迎えるとも考えにくいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_200010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:正面から近づくんじゃなくて<br>大きく北に迂回したのかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_200011")


	--★★ガレス★★:海を見ながら迂回したのかな
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01108_200013")

	PlayAction(Actor004,"to  Std_Angry")
	change_face(Actor004,"Anger")

	--★★リオネス★★:ガレス！気もそぞろ過ぎるぞ！<br>疲れてるのか！？少し休むか！？
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","MA_01108_200015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ガレス★★:そうだな～<br>じゃあ海を見ながら休もうかな～♪
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01108_200017")

	PlayAction(Actor004,"to  Std_Joy")
	change_face(Actor004,"Smile")

	--★★リオネス★★:賛成だ！<br>あと海の幸ことも考えながら！
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","MA_01108_200018")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
DontChangeRandomCamera(true)
on_camera(RndCamera002)
Hide(Actor003)
Hide(Actor004)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
wait_time(1.0)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:故郷の湖を思い出すね、少し
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01108_200020")


	--★★ノワール★★:海と湖じゃ大違いだけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_200021")

	change_face(Actor002,"Smile")

	--★★ディナタン★★:嵐が来て湖が荒れると<br>いつも泣いてたよね、兄さん？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01108_200022")

	PlayAction(Actor001,"to  Std_Sad02")
	change_face(Actor001,"Sad")

	--★★ノワール★★:し、仕方ないだろ、いつも母さんが脅かすから…<br>「悪魔が水底に引っ張り込もうとする音よ」って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_200024")

-- ▼直接出力
CloseTalkWindow()
show_image("still001", 0.0, 0.0, 1.0,true,false)
wait_time(1.8)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01108_20_Water_01")
-- ▲直接出力

	--★★ディナタン★★:悪魔がやってきたぞぉ
	Talk(Actor002,"CHRNAME_DINATAN","simple","L","MA_01108_200026")

	PlayAction(Actor001,"to  Std_Angry")
	change_face(Actor001,"Anger")

	--★★ノワール★★:ヤメロ
	Talk(Actor001,"CHRNAME_NOIR","simple","L","MA_01108_200027")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
se_play("SE_ADV_MA_01108_20_Water_02")
-- ▲直接出力

	--★★ディナタン★★:わぁ～
	Talk(Actor002,"CHRNAME_DINATAN","simple","L","MA_01108_200029")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:や、やめろ！コートに海水が！
	Talk(Actor001,"CHRNAME_NOIR","simple","L","MA_01108_200031")


	--★★ディナタン★★:泣いちゃえ泣いちゃえ
	Talk(Actor002,"CHRNAME_DINATAN","simple","L","MA_01108_200032")


	--★★ノワール★★:泣かないって！
	Talk(Actor001,"CHRNAME_NOIR","simple","L","MA_01108_200033")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
on_camera(RndCamera006)
--フェードイン
wait_time(1.0)
hide_image(1.0)
wait_time(1.8)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:覚えてる？<br>そんなときに母さんが歌ってくれた歌
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01108_200035")

	change_face(Actor002,"Smile")

	--★★ディナタン★★:いつ泣きついてきてもいいよ<br>私が歌ってあげるから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01108_200036")

	change_face(Actor001,"Sad")

	--★★ノワール★★:泣きつかないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_200038")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ディナタン★★:ふふっ…<br>ほかにもね、いろいろ詩を書いてるの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01108_200039")


	--★★ディナタン★★:マァルに教わりながらね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01108_200040")

-- ▼直接出力
on_camera(RndCamera002)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:たとえ癒えないキズがあっても<br>ずっと怖いことがあっても
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01108_200041")


	--★★ディナタン★★:その痛みを忘れるほどイタい歌<br>聞かせてあげるから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01108_200042")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("still001", "content_still_10101019_image", "101010190_StillImage")
	InitializeLoad_Preload()
	load_duel_scene_preload(101050011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor004")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
