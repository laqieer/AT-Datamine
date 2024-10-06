-- このluaスクリプトは、MA_01C112_32.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_002)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002, 0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110101)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("クラリス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クラリス★★:あ！ノワールくん、いらっしゃ～い<br>すみません、今ドタバタしてて
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C112_320002")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★クラリス★★:司祭様にも許可をいただけたので<br>大聖堂を飾り付けようかなって思って
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C112_320003")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ、そうだったのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_320004")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C112_320005","MA_01C112_320006")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:とくに用事があったわけじゃないし<br>俺はすぐに失礼するよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_320008")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("クラリス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クラリス★★:いえいえ！せっかく来てくれたんですから<br>少しお話でもしましょう～
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C112_320009")

	change_face(Actor002,"Normal")

	--★★クラリス★★:ちょうど<br>私も少し休憩したかったところなんです
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C112_320010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにか手伝おうか？<br>こう見えて、細かい作業は得意なんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_320012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("クラリス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クラリス★★:はい、知ってます<br>いつも裁縫されてますもんね
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C112_320013")

-- ▼直接出力
 --PlayPartVoice("クラリス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クラリス★★:でも、大丈夫です。もう少ししたら<br>街のみなさんがお手伝いに来てくれますし
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C112_320014")

	change_face(Actor002,"Normal")

	--★★クラリス★★:モルくんもきっと手伝ってくれます<br>ああ見えて、面倒見がいいんです
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C112_320015")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Anger")

	--★★クラリス★★:「クリスマスだからって浮かれんな！」って<br>モルくんには注意されましたけど
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C112_320017")

-- ▼直接出力
 --PlayPartVoice("クラリス", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クラリス★★:でも、これでみなさんの心もちょっとは<br>明るくなってくれたらいいなぁ
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C112_320018")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力

	--★★クラリス★★:主よ。どうかみんなの心に安らぎを
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C112_320020")

	change_face(Actor002,"Sad")

	--★★クラリス★★:そしてモルくんの背中に灯りかけている<br>不幸の火を…どうか消してあげてください
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C112_320021")

-- ▼直接出力
wait_time(0.7)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("クラリス", "悲しみ")
-- ▲直接出力

	--★★クラリス★★:…わたしって、役立たずですよねぇ<br>見えたからってなにもできない
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C112_320023")


	--★★クラリス★★:モルくんはこんなわたしを捨てずに<br>ずっと一緒にいてくれたのに
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C112_320025")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("クラリス", "落胆")
-- ▲直接出力

	--★★クラリス★★:なのに、祈ることしかできないなんて
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C112_320026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…クラリス？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_320027")

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002, -2,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("クラリス", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クラリス★★:あれ？今通り過ぎたの…<br>モルくんでしたよね？
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C112_320029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:え？　
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_320030")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ノワール", "否定")
-- ▲直接出力

	--★★ノワール★★:いや、あれはただのゴミ袋――
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_320031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("クラリス", "肯定3")
-- ▲直接出力

	--★★クラリス★★:わわ、たいへんです！　<br>モルくんが飛んでいっちゃいました～
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C112_320032")

-- ▼直接出力
CloseTalkWindow()
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to Run")
slidemove(Actor002,0.28,0,1.2,3.5)
turn_chara(Actor001, 6.1, 0)
wait_time(0.9)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to Run")
-- ▲直接出力

	--★★クラリス2★★:モルくん、待ってくださーい！
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C112_320033")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110101)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
