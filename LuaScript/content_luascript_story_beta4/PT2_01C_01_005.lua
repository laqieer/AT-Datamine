-- このluaスクリプトは、PT2_01C_01_005.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_006)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor003,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115907)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("フレン","挨拶")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★フレン★★:ノワールくん、聞いたよ！
	Talk(Actor003,"CHRNAME_FREN","speech","L","PT2_01C_01_0050002")

	change_face(Actor003,"Normal")

	--★★フレン★★:キャメリアード城で<br>ギネマウアさんに会ったんだよね？
	Talk(Actor003,"CHRNAME_FREN","speech","L","PT2_01C_01_0050003")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Surprise")

	--★★フレン★★:ギネマウアさん、なんて言ってたの？<br>あと、ギネヴィア王妃はどうしたの？
	Talk(Actor003,"CHRNAME_FREN","speech","L","PT2_01C_01_0050004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ローラ","怒り")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ローラ★★:お姉ちゃん、落ち着いて<br>ノワールさんも困ってるよ
	Talk(Actor002,"CHRNAME_LOLA","speech","L","PT2_01C_01_0050005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力

	--★★ノワール★★:あ、ありがとう、ローラ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_01_0050006")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:ギネマウアさんが言うには<br>俺とギネヴィアは入れ違いになったって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_01_0050007")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("フレン","悩む")
-- ▲直接出力

	--★★フレン★★:入れ違い？<br>でも、ギネヴィア王妃の姿は見てないよ？
	Talk(Actor003,"CHRNAME_FREN","speech","L","PT2_01C_01_0050008")

-- ▼直接出力
PlayPartVoice("ローラ","悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ローラ★★:帰り道で迷ってる…<br>なんてことはないでしょうしね
	Talk(Actor002,"CHRNAME_LOLA","speech","L","PT2_01C_01_0050009")

-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フレン","悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★フレン★★:もしかしてバルバロイに…
	Talk(Actor003,"CHRNAME_FREN","speech","L","PT2_01C_01_0050010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★ローラ★★:お姉ちゃん！！
	Talk(Actor002,"CHRNAME_LOLA","speech","L","PT2_01C_01_0050011")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力

	--★★ノワール★★:大丈夫だよ<br>ギネヴィアは強いから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_01_0050012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:ここで待ってみようと思う<br>彼女は俺に会いに来るって言ってたそうだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_01_0050013")

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
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
