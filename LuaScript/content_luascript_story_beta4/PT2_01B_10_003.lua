-- このluaスクリプトは、PT2_01B_10_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Npc_015_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_015)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_03_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_016)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101066","001","101066001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ブレイズ", "挨拶")
-- ▲直接出力

	--★★ブレイズ★★:………では<br>今日の授業はここまでにするかの
	Talk(Actor003,"CHRNAME_BLAZE","speech","L","PT2_01B_10_0030004")


	--★★ブレイズ★★:明日は万聖の祝日じゃ
	Talk(Actor003,"CHRNAME_BLAZE","speech","L","PT2_01B_10_0030005")


	--★★ブレイズ★★:ワシらの今を作ってくれた<br>太古の聖人たちへ感謝の思いを伝えつつ
	Talk(Actor003,"CHRNAME_BLAZE","speech","L","PT2_01B_10_0030006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ブレイズ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ブレイズ★★:ゆっくり体を休めるようにの
	Talk(Actor003,"CHRNAME_BLAZE","speech","L","PT2_01B_10_0030007")

	change_face(Actor003,"Normal")

	--★★ブレイズ★★:じゃが、ノワールにガラハッド
	Talk(Actor003,"CHRNAME_BLAZE","speech","L","PT2_01B_10_0030008")

-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定2")
-- ▲直接出力

	--★★ガラハッド★★:なんだろうか？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT2_01B_10_0030009")


	--★★ブレイズ★★:お主らは聖杯探索の遠征続きで<br>授業に遅れが出ておる
	Talk(Actor003,"CHRNAME_BLAZE","speech","L","PT2_01B_10_0030010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ブレイズ", "納得")
-- ▲直接出力

	--★★ブレイズ★★:明日の祝日を使って<br>特別授業をやるそうじゃ
	Talk(Actor003,"CHRNAME_BLAZE","speech","L","PT2_01B_10_0030011")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なんだって！？<br>誰がそんなことを言い出したんですか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_10_0030012")

-- ▼直接出力
PlayPartVoice("ブレイズ", "驚き")
-- ▲直接出力

	--★★ブレイズ★★:ランスロットじゃ
	Talk(Actor003,"CHRNAME_BLAZE","speech","L","PT2_01B_10_0030013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:あいつ…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_10_0030014")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:これは逃れようがなさそうだな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_10_0030015")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101066","001","101066001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
