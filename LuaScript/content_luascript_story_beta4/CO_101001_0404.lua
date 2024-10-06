-- このluaスクリプトは、CO_101001_0404.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_02","112021_02_h")
Include("content_adv_advsmall_112021_02","Template112021_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_008)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112021_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos112021_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPos112021_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_001)
	InitializeTemplateRandomCamera112021_02()
	InitializeTemplate112021_02()
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
load_image("104000090", "content_still_10400009_image", "104000090_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401021","001","401021001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:ティルフィング？<br>どうした？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_04040002")

-- ▼直接出力
PlayPartVoice("ティルフィング", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:あ、マスター…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_04040003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:なにを見てるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_04040005")

-- ▼直接出力
setup_small_camera_start()
ShowImageItem("104000090")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定3")
-- ▲直接出力

	--★★ティルフィング★★:いえ、これ…<br>小さくて可愛らしいな、って思いまして
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_04040007")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:こんな食べ物は初めて見るので<br>つい目を奪われてしまいました
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_04040008")

-- ▼直接出力
HideImageItem()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("市民中年_男2", "挨拶")
-- ▲直接出力

	--★★市民（中年男）②★★:おっ、お嬢さん<br>いい目の付けどころをしてるね！
	Talk(Actor006,"NPCNAME_0276","speech","N","CO_101001_04040009")

	PlayAction(Actor006,"to  Std_Talk")

	--★★市民（中年男）②★★:それはマカロンっていうスイーツさ
	Talk(Actor006,"NPCNAME_0276","speech","N","CO_101001_04040010")


	--★★市民（中年男）②★★:今女の子に大人気の<br>うちの目玉商品だよ！
	Talk(Actor006,"NPCNAME_0276","speech","N","CO_101001_04040011")

-- ▼直接出力
PlayPartVoice("市民中年_男2", "肯定2")
-- ▲直接出力

	--★★市民（中年男）②★★:ここで食べておかないと<br>流行に乗り遅れちゃうよ？
	Talk(Actor006,"NPCNAME_0276","speech","N","CO_101001_04040012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:食べてみるか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_04040013")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "否定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:い、いえマスター<br>私は構いませんので
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_04040015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "挨拶")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor003,"Normal")

	--★★ディナタン★★:兄さん、ティルフィングさん！<br>遅れてるよー…って
	Talk(Actor003,"CHRNAME_DINATAN","speech","N","CO_101001_04040017")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ディナタン★★:どうしたの？
	Talk(Actor003,"CHRNAME_DINATAN","speech","N","CO_101001_04040018")

	close_cutin()
-- ▼直接出力
 --ディナタンたち登場
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Appear(Actor003)
Appear(Actor004)
Appear(Actor005)
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ガレス★★:なんだなんだ～？
	Talk(Actor004,"CHRNAME_GARETH","speech","L","CO_101001_04040020")

-- ▼直接出力
PlayPartVoice("リオネス", "挨拶")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★リオネス★★:うまそうなの、見つけたか？
	Talk(Actor005,"CHRNAME_LYONESS","speech","L","CO_101001_04040021")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:この、マカロンってやつを<br>ティルフィングに買ってやろうかと…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_04040022")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディナタン★★:えっ、なにこれカワイイ！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101001_04040023")

	PlayAction(Actor003,"to  Std_Joy")

	--★★ディナタン★★:兄さん！私も！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101001_04040025")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_04040026")

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ガレス★★:じゃあわたしも！
	Talk(Actor004,"CHRNAME_GARETH","speech","L","CO_101001_04040028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("リオネス", "笑い")
-- ▲直接出力

	--★★リオネス★★:あたしもな！
	Talk(Actor005,"CHRNAME_LYONESS","speech","L","CO_101001_04040030")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:ちょ、ちょっと…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_04040031")

-- ▼直接出力
PlayPartVoice("ティルフィング", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ティルフィング★★:マスター…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_04040033")

	open_select_window_tag(Actor001,"Normal","CO_101001_04040035","CO_101001_04040036")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あ～～もう、わかった！<br>わかったよ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_04040038")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:全員ぶん買ってやるから<br>そんな目で見るな！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_04040039")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ディナタン", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディナタン★★:やったー！<br>さすが兄さん！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101001_04040041")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:待て待て、そんな予定は…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_04040043")

	PlayAction(Actor003,"to  Std_Angry")
	change_face(Actor003,"Sad")

	--★★ディナタン★★:えー！<br>兄さんのケチー！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101001_04040044")

	PlayAction(Actor004,"to  Std_Angry")
	change_face(Actor004,"Anger")

	--★★ガレス★★:ケチ～！
	Talk(Actor004,"CHRNAME_GARETH","speech","L","CO_101001_04040045")

	PlayAction(Actor005,"to  Std_Angry")
	change_face(Actor005,"Anger")

	--★★リオネス★★:ケチー！
	Talk(Actor005,"CHRNAME_LYONESS","speech","L","CO_101001_04040046")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ぐぅっ…！ここで断ったら<br>兄としての、いや騎士としてのメンツが…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_04040048")

	goto Block1end

::Block1end::
-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ティルフィング_ランクアップ4_5")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("104000090", "content_still_10400009_image", "104000090_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401021","001","401021001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
