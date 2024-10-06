-- このluaスクリプトは、PT2_01_05_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor002",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor003",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor003,Actor002,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115907)
	Actor001 = InitializeCharacter_2DOnly("101009","002","101009002")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor001,"Surprise")

	--★★ノワール★★:（ディナタンと、あの子は…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","PT2_01_05_0020005")

-- ▼直接出力
PlayPartVoice("ディナタン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:どうして今日<br>授業に来なかったの？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_05_0020006")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力

	--★★マルディサント★★:理由なんかひとつっきゃねーだろ<br>ツマンなさそーだったからだよ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","PT2_01_05_0020007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:ダメだよ、授業はちゃんと出ないと
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_05_0020008")


	--★★ディナタン★★:マルディサントも儀式は終わってるんでしょ？<br>だったらつがいを見つけるためにも－－
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_05_0020009")

	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("マルディサント", "激怒")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★マルディサント★★:うざッ！うざッ！<br>良い子ちゃんの理論をアタシに押し付けんな！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","PT2_01_05_0020010")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（出て行ったほうがいいか…？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","PT2_01_05_0020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ディナタン★★:私、あなたと一緒に授業受けたい
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_05_0020012")

-- ▼直接出力
PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★マルディサント★★:はぁ？<br>なに言ってんだアンタ！？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","PT2_01_05_0020013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:受けたいの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_05_0020014")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("マルディサント", "否定")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★マルディサント★★:あ～～～～～もう！<br>ホント調子狂うぜ、アンタといると
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","PT2_01_05_0020015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルディサント", "落胆")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マルディサント★★:わかった、わかったよ<br>明日はちゃんと出るから
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","PT2_01_05_0020016")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ディナタン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:本当？うれしい！<br>えへへっ…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_05_0020017")

	change_face(Actor001,"Normal")

	--★★ノワール★★:（…大丈夫そうだな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","PT2_01_05_0020018")

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
	InitializeCharacter_2DOnly_Preload("101009","002","101009002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
