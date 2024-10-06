-- このluaスクリプトは、MA_01B112_09.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111016_10","111016_10_h")
Include("content_adv_advsmall_111016_10","Template111016_10_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111016_10_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName111016_10,CameraPos111016_10_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111016_10_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName111016_10,CameraPos111016_10_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111016_10_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_015_01_StdController","to Std_Loop",CameraAssetBundleName111016_10,CameraPos111016_10_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111016_10_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_016_01_StdController","to Std_Loop",CameraAssetBundleName111016_10,CameraPos111016_10_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111016_10_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_017_01_StdController","to Std_Loop",CameraAssetBundleName111016_10,CameraPos111016_10_003)
	InitializeTemplateRandomCamera111016_10()
	InitializeTemplate111016_10()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111016)
	Actor001 = InitializeCharacter_3D("101056","002","101056002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101053","002","101053002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101054","002","101054002","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101055","002","101055002","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★マーリン★★:…合点がいきました
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01B112_090002")

	PlayAction(Actor002,"to  Std_Talk")

	--★★マーリン★★:あなたたちが護らんとしている者はすなわち<br>…ノワール様とランスロット様ですね
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01B112_090003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ペレス★★:銀卓騎士は皆──迷える孤児
	Talk(Actor001,"CHRNAME_PEREZ","speech","R","MA_01B112_090004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ペレス★★:カレドニアやバルバロイにより<br>誰もが帰る場所を失った
	Talk(Actor001,"CHRNAME_PEREZ","speech","R","MA_01B112_090005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ペレス★★:親に頼る歳でない者がいたとしても<br>バルバロイはびこる地においては、みなしご同然
	Talk(Actor001,"CHRNAME_PEREZ","speech","R","MA_01B112_090006")


	--★★ペレス★★:『父なる彼』はその者たちを<br>この聖杯城へと引き取って来た
	Talk(Actor001,"CHRNAME_PEREZ","speech","R","MA_01B112_090007")


	--★★ペレス★★:儂と彼らは身を寄せ合い<br>互いを愛し合い、孤独を癒していった
	Talk(Actor001,"CHRNAME_PEREZ","speech","R","MA_01B112_090008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★マーリン★★:ペレス王にとっても<br>大恩ある御方であったと
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01B112_090009")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ペレス★★:無論
	Talk(Actor001,"CHRNAME_PEREZ","speech","R","MA_01B112_090010")


	--★★ペレス★★:我が子ら、我が家を、我が身を<br>長きに渡り護り続けてくれた御方だ
	Talk(Actor001,"CHRNAME_PEREZ","speech","R","MA_01B112_090011")


	--★★ペレス★★:『父なる彼』が実の<dot>子</dot>ノワール卿と<br>弟<dot>子</dot>であるランスロット卿を遺された
	Talk(Actor001,"CHRNAME_PEREZ","speech","R","MA_01B112_090012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ペレス★★:そして聖杯城に加護を与えし妖精ニニアン<br><dot>彼女の願いを聞き届け</dot>、妖精殺しを成し遂げた
	Talk(Actor001,"CHRNAME_PEREZ","speech","R","MA_01B112_090014")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★マーリン★★:………ご存じなのですね
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01B112_090016")

	PlayAction(Actor002,"to  Std_Talk")

	--★★マーリン★★:妖精殺しは咎ではなく<br>彼女自身の願いであったことを
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01B112_090017")

-- ▼直接出力
setup_small_camera_start(RndCamera011)
-- ▲直接出力

	--★★ペレス★★:もとよりこの城は妖精ニニアンの住まう場所<br>父なる彼が遺せし場所
	Talk(Actor001,"CHRNAME_PEREZ","speech","R","MA_01B112_090019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★ペレス★★:この命を<ruby=と>賭</ruby>し<br>護らぬ理由はない
	Talk(Actor001,"CHRNAME_PEREZ","speech","R","MA_01B112_090020")

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
	InitializeCharacter_3D_Preload("101056","002","101056002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101053","002","101053002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101054","002","101054002","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101055","002","101055002","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111016_10)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
