-- このluaスクリプトは、MA_01108_35.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",25,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_017_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",-146.499,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_508_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_016_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_015_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera008 = SetTemplate("Actor008",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
change_weather_cloudy(true)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101020022)
	Actor001 = InitializeCharacter_3D("101034","002","101034002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101035","002","101035002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101055","001","101055001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101029","001","101029001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101054","001","101054001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101053","001","101053001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_2DOnly("101010","001","101010001")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★エクセリア★★:カレドニア軍は<br>一時撤退していったようです
	Talk(Actor001,"CHRNAME_EXCELIA2","speech","L","MA_01108_350002")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
DontChangeRandomCamera(true)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★リリアーナ★★:助勢に感謝します…<br>円卓の騎士のみなさま…！
	Talk(Actor002,"CHRNAME_LILIANA2","speech","L","MA_01108_350003")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力

	--★★オーウェン★★:助けなどなくとも<br>奴らが長城を抜くことは不可能だったが
	Talk(Actor003,"CHRNAME_OWEN","speech","L","MA_01108_350005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★アステラ★★:「わざわざ助けに来てくださりありがとう<br>急ぎ来てくれたのなら申し訳ない」と言ってるわ
	Talk(Actor004,"CHRNAME_ASTERA","speech","L","MA_01108_350007")

	PlayAction(Actor003,"to  Std_Talk")

	--★★オーウェン★★:…我がキラーズを送り届けてくれたことには<br>深く礼を述べる
	Talk(Actor003,"CHRNAME_OWEN","speech","L","MA_01108_350008")


	--★★アダン★★:ガラハッドは？
	Talk(Actor005,"CHRNAME_ADAM","speech","L","MA_01108_350009")

	change_face(Actor004,"Normal")

	--★★アステラ★★:ペレス王への薬が間に合ったわ<br>今はそばについてあげているみたい
	Talk(Actor004,"CHRNAME_ASTERA","speech","L","MA_01108_350010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Sad01")

	--★★マターヤ★★:頭が上がらないねー、どーもー
	Talk(Actor006,"CHRNAME_MATHAJIM","speech","L","MA_01108_350011")


	--★★マターヤ★★:ガラハッドの留学受け入れ、薬のお届け<br>カレドニア包囲網の排除、本当に助かったよー
	Talk(Actor006,"CHRNAME_MATHAJIM","speech","L","MA_01108_350012")


	--★★マターヤ★★:僕は銀卓騎士団一の脚にして<br>団長のマターヤ
	Talk(Actor006,"CHRNAME_MATHAJIM","speech","L","MA_01108_350013")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:わっ、わたしはリリアーナ<br>マターヤのキラーズ…です…
	Talk(Actor002,"CHRNAME_LILIANA2","speech","L","MA_01108_350015")

-- ▼直接出力
OpenFirstAppearance(Actor002)
setup_small_camera_end()
-- ▲直接出力

	--★★アダン★★:自分は銀卓騎士団二の脚アダン<br>参謀も務めています
	Talk(Actor005,"CHRNAME_ADAM","speech","L","MA_01108_350016")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★エクセリア★★:私はエクセリア。アダンのキラーズです<br>以後、お見知りおきを
	Talk(Actor001,"CHRNAME_EXCELIA2","speech","L","MA_01108_9010002")

-- ▼直接出力
OpenFirstAppearance(Actor001)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("アステラ","0007")
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★アステラ★★:…戦いの場にいられず申し訳なかったね<br>なにがあったかは想像に難くないけど──
	Talk(Actor004,"CHRNAME_ASTERA","speech","L","MA_01108_9010003")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("オーウェン","肯定2")
-- ▲直接出力

	--★★オーウェン★★:哀悼の意を表させていただくよ
	Talk(Actor003,"CHRNAME_OWEN","speech","L","MA_01108_9010004")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マターヤ","肯定3")
-- ▲直接出力

	--★★マターヤ★★:それじゃコルベニック城へ案内…
	Talk(Actor006,"CHRNAME_MATHAJIM","speech","L","MA_01108_9010005")


	--★★マターヤ★★:…ノワール、大丈夫？
	Talk(Actor006,"CHRNAME_MATHAJIM","speech","L","MA_01108_9010007")

	PlayAction(Actor006,"to Bow")

	--★★マターヤ★★:あ、ああ…
	Talk(Actor006,"CHRNAME_MATHAJIM","speech","L","MA_01108_9010008")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101020022)
	InitializeCharacter_3D_Preload("101034","002","101034002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101035","002","101035002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101055","001","101055001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101029","001","101029001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101054","001","101054001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101053","001","101053001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_2DOnly_Preload("101010","001","101010001")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
