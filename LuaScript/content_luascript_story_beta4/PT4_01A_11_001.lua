-- このluaスクリプトは、PT4_01A_11_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
lookat_weight(Actor002,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115910)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:学園祭も終わって<br>ホッとひといきって感じか、エレイン？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_11_0010002")

-- ▼直接出力
PlayPartVoice("エレイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:あっ、先輩！<br>おはようございます
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","PT4_01A_11_0010003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:あらためて<br>学園祭の実行委員、お疲れ様
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_11_0010004")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "照れ")
-- ▲直接出力

	--★★エレイン★★:いえ、そんな！<br>先輩たちにいろいろ手伝ってもらったおかげです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","PT4_01A_11_0010005")

	change_face(Actor002,"Smile")

	--★★エレイン★★:お芝居が成功したのは<br>先輩の木の演技があったからですよ！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","PT4_01A_11_0010006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…褒めてるのか、それ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_11_0010007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:ほ、褒めてますよっ！なんというか<br>木の人生設計が見えたような気がしました！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","PT4_01A_11_0010008")

-- ▼直接出力
PlayPartVoice("ノワール", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:なんだそれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_11_0010009")

-- ▼直接出力
PlayPartVoice("エレイン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:あははっ！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","PT4_01A_11_0010010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:先輩…<br>みなさん、学園祭を楽しんでくれたでしょうか？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","PT4_01A_11_0010011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、間違いなくね
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_11_0010012")

	change_face(Actor002,"Smile")

	--★★エレイン★★:そ、そうですか…<br>それなら、よかったです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","PT4_01A_11_0010013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:来年もやろうな、学園祭
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_11_0010014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "笑い")
-- ▲直接出力

	--★★エレイン★★:はい！<br>私、また実行委員に立候補します
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","PT4_01A_11_0010015")


	--★★ノワール★★:また演劇があったらどうする？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_11_0010016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エレイン★★:えっと…先輩が一緒にやってくれるなら…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","PT4_01A_11_0010017")

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:また木じゃなければ、考えてもいいかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_11_0010018")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115910)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
