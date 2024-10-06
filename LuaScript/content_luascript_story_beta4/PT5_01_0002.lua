-- このluaスクリプトは、PT5_01_0002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Npc_015_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_016)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_015)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115020)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ブレイズ", "肯定2")
-- ▲直接出力

	--★★ブレイズ★★:今日はバルバロイの特徴のひとつ<br>記憶を喰らう、について学んでいこうかの
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00020002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ブレイズ★★:バルバロイが人間を襲う理由<br>それは人間の記憶が彼奴らの活力源だからじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00020003")


	--★★ブレイズ★★:バルバロイどもは己が活動するために<br>人間を傷つけ、命を奪い、その記憶を喰らう
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ブレイズ★★:基本的に<br>バルバロイは自我をもたぬがゆえ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00020005")


	--★★ブレイズ★★:ハラが減ったときにエサがそこにあれば<br>躊躇なく喰らいつく
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00020006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ブレイズ", "怒り")
-- ▲直接出力

	--★★ブレイズ★★:獣と同じじゃよ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00020007")


	--★★ブレイズ★★:さて。ここからが重要であり<br>バルバロイの恐ろしさなのじゃが…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00020008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ブレイズ★★:バルバロイに喰われた記憶は<br>決して戻ってくることはない
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00020009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ブレイズ★★:そして、すべての記憶が喰われたとき<br>その者の存在記憶が世界から失われてしまう
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00020010")


	--★★ブレイズ★★:これがどういうことかというとじゃな
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00020011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ブレイズ★★:自分がバルバロイに<br>すべての記憶を喰われたとする
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00020012")


	--★★ブレイズ★★:すると、周りの人間は<br>その者についてのいっさいの記憶を失うのじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00020013")


	--★★ブレイズ★★:その者が<br>バルバロイに襲われて死んだということすらな
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00020014")


	--★★ブレイズ★★:お主らはこれから学園で<br>バルバロイと戦う術を身に着けていくじゃろう
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00020015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ブレイズ★★:しかし<br>くれぐれも無理はせんでくれ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00020016")


	--★★ブレイズ★★:仲間や知人が<br>戦で命を落とすのは確かに辛い
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00020017")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ブレイズ★★:じゃが、もっと辛いのは<br>命を落としたということすら忘れられることじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00020018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:全員が無事この学園を卒業し<br>数年後に再び集まって当時のことを懐かしむ…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00020019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ブレイズ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:ワシはそんな未来を望んでおるよ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00020020")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115020)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
