-- このluaスクリプトは、PT5_01_0015.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
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
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:ＧＳを済ませると<br>武器であるキラーズには銘が与えられる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00150002")


	--★★ランスロット★★:銘はマスター側の因子の記憶に<br>刻まれているとされているもので
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00150003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力

	--★★ランスロット★★:キラーズ側には<br>得意とする戦闘スタイルの記憶が刻まれている
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00150004")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:このふたつの記憶が結合し<br>キラーズの銘とスタイルが定まるわけだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00150005")


	--★★ランスロット★★:参考までにラグネル<br>お前の銘とスタイルを教えてくれるか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00150006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力

	--★★ラグネル★★:あたしはガラティンという銘をもらって<br>斧を使って戦えるようになりました
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","PT5_01_00150007")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:ありがとう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00150008")


	--★★ランスロット★★:ひとつ補足しておくとキラーズ側の武器の記憶は<br>当人の想いの影響も大きいと聞く
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00150009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:つまりラグネルのなかに<br>斧を使って戦いたいという想いがあったのかもな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00150010")

-- ▼直接出力
PlayPartVoice("ラグネル", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ラグネル★★:えっ？<br>そうなの、かなあ…？
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","PT5_01_00150011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ガウェイン★★:お前、すげー物騒じゃん…
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","PT5_01_00150012")

-- ▼直接出力
PlayPartVoice("ラグネル", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ラグネル★★:うっさい！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","PT5_01_00150013")

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
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
