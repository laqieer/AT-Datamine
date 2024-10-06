-- このluaスクリプトは、CO_101025_0702_1.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_008)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401036","001","401036001","content_animationpack__common","FacialPack","Actor004")
	template1()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:今、この人物を探しているんですが<br>ご存知ないですか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_07020006")

-- ▼直接出力
PlayPartVoice("兵士1", "肯定2")
-- ▲直接出力

	--★★キャメロット軍兵士_下位★★:ん…ジャスパーじゃないか<br>数年前まで冒険者をやってたヤツだよ
	Talk(Actor004,"NPCNAME_0270","speech","N","CO_101025_07020007")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("クレア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クレア★★:知っているの！？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_07020008")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("兵士1", "肯定3")
-- ▲直接出力

	--★★キャメロット軍兵士_下位★★:魔法使いとして<br>そこそこ腕の立つヤツだったんだけど
	Talk(Actor004,"NPCNAME_0270","speech","N","CO_101025_07020009")


	--★★キャメロット軍兵士_下位★★:戦いで負ったキズが原因で<br>うまく魔法が使えなくなって
	Talk(Actor004,"NPCNAME_0270","speech","N","CO_101025_07020010")


	--★★キャメロット軍兵士_下位★★:自暴自棄の果て<br>怪しげな連中とつるむようになったと聞いた
	Talk(Actor004,"NPCNAME_0270","speech","N","CO_101025_07020011")

	PlayAction(Actor004,"to  Std_Talk")

	--★★キャメロット軍兵士_下位★★:酒場に行ってみたらどうだい？<br>ジャスパーの知り合いがいるかもしれない
	Talk(Actor004,"NPCNAME_0270","speech","N","CO_101025_07020012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:さっそく行ってみるよ<br>ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_07020013")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_クレア_ランクアップ7_3")
-- ▲直接出力
	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401036","001","401036001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
