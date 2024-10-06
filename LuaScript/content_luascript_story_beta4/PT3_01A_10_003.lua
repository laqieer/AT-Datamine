-- このluaスクリプトは、PT3_01A_10_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_04","110191_04_h")
Include("content_adv_advsmall_110191_04","Template110191_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_002)
	InitializeTemplateRandomCamera110191_04()
	InitializeTemplate110191_04()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115200)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("マルディサント","悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルディサント★★:アアー…あそこはああで、いややっぱ<br>あの流れからこっちに…
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT3_01A_10_0030003")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:（マルディサント…？<br>朝から虚ろな目でブツブツ言ってるけど…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","PT3_01A_10_0030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("マルディサント","挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルディサント★★:よう、オニーサン<br>相変わらず朝から冴えないツラしてんな
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT3_01A_10_0030005")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール","挨拶")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:おはよう<br>そっちは朝からなんか調子悪そうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_10_0030006")

-- ▼直接出力
PlayPartVoice("マルディサント","落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルディサント★★:昨日の夜から舞台の脚本を考えてたんだけどよ<br>気付いたら朝になっちまってた
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT3_01A_10_0030007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:まさか、一睡もしてないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_10_0030008")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルディサント","肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルディサント★★:こんくらいいつものことだよ<br>ヨユーヨユー
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT3_01A_10_0030009")

	change_face(Actor002,"Normal")

	--★★マルディサント★★:ただ、ちょっと煮詰まって来たから<br>気分転換に屋上にでも行ってくるわ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT3_01A_10_0030010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…授業は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_10_0030011")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("マルディサント","怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★マルディサント★★:ハァ？授業に出んのと<br>舞台の脚本を仕上げんの、どっちが大事だよ！？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT3_01A_10_0030012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★ノワール★★:どっちも大事だろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_10_0030013")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("マルディサント","苦しみ")
-- ▲直接出力

	--★★マルディサント★★:…ぐっ！<br>兄妹そろって正論ぶつけてきやがる…！
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT3_01A_10_0030014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルディサント","落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルディサント★★:午後からは授業出るからさ<br>ここは見逃してくれって。な、頼むよ？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT3_01A_10_0030015")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:まったく…仕方のないヤツだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_10_0030016")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115200)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
