-- このluaスクリプトは、PT2_01C_01_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115907)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ガレス","挨拶")
-- ▲直接出力

	--★★ガレス★★:ノワール、聞いたぞ～！<br>ギネヴィアを探しに行くんだって？
	Talk(Actor003,"CHRNAME_GARETH","speech","L","PT2_01C_01_0010005")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ガレス★★:いつ出発するんだ？<br>わたしもついていくぞ～♪
	Talk(Actor003,"CHRNAME_GARETH","speech","L","PT2_01C_01_0010006")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("リオネス","笑い")
-- ▲直接出力

	--★★リオネス★★:あたしも行くぞ！
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","PT2_01C_01_0010007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力

	--★★ノワール★★:ガレスたちがついてきてくれるのか<br>心強いな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_01_0010008")


	--★★ノワール★★:ギネヴィアをさがしにキャメリアードに行くのは<br>８日後にしようと思ってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_01_0010009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス","肯定")
-- ▲直接出力

	--★★リオネス★★:８日後だな！了解だ！
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","PT2_01C_01_0010010")

-- ▼直接出力
PlayPartVoice("ガレス","悩む")
-- ▲直接出力

	--★★ガレス★★:それまでにギネヴィアとギネマウアの<br>好きだった料理の材料を準備しておかないとな
	Talk(Actor003,"CHRNAME_GARETH","speech","L","PT2_01C_01_0010011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")

	--★★ガレス★★:戻ってきたら<br>好きなだけ食べさせてやるんだ♪
	Talk(Actor003,"CHRNAME_GARETH","speech","L","PT2_01C_01_0010012")


	--★★ノワール★★:あのふたりも<br>よく食堂に来てたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_01_0010013")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス","肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガレス★★:いつもふたり一緒に来て<br>仲良く話しながら食べてくれてたぞ♪
	Talk(Actor003,"CHRNAME_GARETH","speech","L","PT2_01C_01_0010014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("リオネス","肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リオネス★★:ノワールが学園に来る前は<br>ギネヴィアはぼっちメシが多かったけどな！
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","PT2_01C_01_0010015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定3")
-- ▲直接出力

	--★★ノワール★★:へえ<br>そうだったのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_01_0010016")

	change_face(Actor003,"Normal")

	--★★ガレス★★:食卓は家族や友達と一緒に<br>笑顔で囲まないとな♪
	Talk(Actor003,"CHRNAME_GARETH","speech","L","PT2_01C_01_0010017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力

	--★★ノワール★★:…そうだな<br>ふたりを早く笑顔の食卓に戻してやりたいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_01_0010018")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115907)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
