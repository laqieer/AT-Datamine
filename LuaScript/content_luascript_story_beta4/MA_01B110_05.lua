-- このluaスクリプトは、MA_01B110_05.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111016_02","111016_02_h")
Include("content_adv_advsmall_111016_02","Template111016_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111016_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_015_01_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_003)
	Camera002 = SetTemplate("Actor002",-60,CharaPos111016_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111016_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_016_01_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_002)
	Camera004 = SetTemplate("Actor004",-100,CharaPos111016_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111016_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_017_01_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_001)
	Camera006 = SetTemplate("Actor006",-140,CharaPos111016_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_508_01_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_008)
	Camera007 = SetTemplate("Actor007",nil,CharaPos111016_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_004)
	Camera008 = SetTemplate("Actor008",nil,CharaPos111016_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_005)
	InitializeTemplateRandomCamera111016_02()
	InitializeTemplate111016_02()
-- ▼直接出力
set_enable_auto_lookat_all(false)
set_pos(Actor002,{2,0,17.8})
set_pos(Actor004,{1.8,0,19.5})
set_pos(Actor006,{0.8,0,20.7})
set_pos(Actor007,{-0.7,0,18.3})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111016)
	Actor001 = InitializeCharacter_3D("101053","001","101053001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101035","002","101035002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101054","001","101054001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101034","002","101034002","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101055","001","101055001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101029","001","101029001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101048","001","101048001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101049","001","101049001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_2DOnly("101044","001","101044001")
	Actor010 = InitializeCharacter_2DOnly("101045","001","101045001")
	Actor011 = InitializeCharacter_2DOnly("101046","001","101046001")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★マターヤ★★:口を閉ざし<br>二度と語らせてくれるなよ
	Talk(Actor001,"CHRNAME_MATHAJIM","speech","L","MA_01B110_050002")

-- ▼直接出力
 --PlayPartVoice("グリーテン", "肯定2")
-- ▲直接出力

	--★★グリーテン★★:無論です
	Talk(Actor009,"CHRNAME_SISTERS_3","speech","L","MA_01B110_050003")


	--★★アダン★★:死期も病も気取られぬまま
	Talk(Actor003,"CHRNAME_ADAM","speech","L","MA_01B110_050004")

-- ▼直接出力
 --PlayPartVoice("グリートーネア", "笑い")
-- ▲直接出力
	change_face(Actor010,"Smile")

	--★★グリートーネア★★:魂は我らが胃の中
	Talk(Actor010,"CHRNAME_SISTERS_4","speech","L","MA_01B110_050005")


	--★★オーウェン★★:遠く離れた此処より想う
	Talk(Actor005,"CHRNAME_OWEN","speech","L","MA_01B110_050006")

-- ▼直接出力
 --PlayPartVoice("グリートン", "肯定3")
-- ▲直接出力

	--★★グリートン★★:虚ろとなり果て<br>それで満足？
	Talk(Actor011,"CHRNAME_SISTERS_5","speech","L","MA_01B110_050007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_No")
	change_face(Actor006,"Anger")

	--★★アステラ★★:どのみち避けられないのなら
	Talk(Actor006,"CHRNAME_ASTERA","speech","L","MA_01B110_050008")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★エクセリア★★:私たちだけでも<br>そばにいるわ
	Talk(Actor004,"CHRNAME_EXCELIA","speech","L","MA_01B110_050009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★リリアーナ★★:…『家族』として
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","MA_01B110_050010")

	PlayAction(Actor007,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ティーテン", "落胆")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★ティーテン★★:それは<br>自分を縛り付けるだけの枷じゃなあい？
	Talk(Actor007,"CHRNAME_SISTERS_7","speech","L","MA_01B110_050011")

	PlayAction(Actor008,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ティートン", "肯定")
-- ▲直接出力
	change_face(Actor008,"Smile")

	--★★ティートン★★:その呼び名を言い訳に<br>あなたたちは<ruby=ぬかるみ>泥濘</ruby>へ足を取られる…
	Talk(Actor008,"CHRNAME_SISTERS_8","speech","L","MA_01B110_050012")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アステラ", "肯定2")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★アステラ★★:そういう生きかたも好きよ
	Talk(Actor006,"CHRNAME_ASTERA","speech","L","MA_01B110_050014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★アダン★★:穢れなき受け皿は放たれた<br>曇りなき玻璃の銀も彼女のみ
	Talk(Actor003,"CHRNAME_ADAM","speech","L","MA_01B110_050015")


	--★★オーウェン★★:汚水で溢るる救いの道が<br>清水に流され去るのなら
	Talk(Actor005,"CHRNAME_OWEN","speech","L","MA_01B110_050017")


	--★★マターヤ★★:みなしごが帰る道は
	Talk(Actor001,"CHRNAME_MATHAJIM","speech","L","MA_01B110_050018")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111016)
	InitializeCharacter_3D_Preload("101053","001","101053001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101035","002","101035002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101054","001","101054001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101034","002","101034002","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101055","001","101055001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101029","001","101029001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101048","001","101048001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101049","001","101049001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_2DOnly_Preload("101044","001","101044001")
	InitializeCharacter_2DOnly_Preload("101045","001","101045001")
	InitializeCharacter_2DOnly_Preload("101046","001","101046001")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111016_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
