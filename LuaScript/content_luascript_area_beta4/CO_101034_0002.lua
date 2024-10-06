-- このluaスクリプトは、CO_101034_0002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112011_01","112011_01_h")
Include("content_adv_advsmall_112011_01","Template112011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",84,CharaPos112011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112011_01,CameraPos112011_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName112011_01,CameraPos112011_01_003)
	InitializeTemplateRandomCamera112011_01()
	InitializeTemplate112011_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("エクセリア", "挨拶")
-- ▲直接出力

	--★★エクセリア★★:ノワールひとつ聞いていいかしら？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_00010008")

	PlayAction(Actor002,"to  Std_Talk")

	--★★エクセリア★★:あなたはなぜ私をここに連れてこようと思ったの？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_00010009")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力

	--★★ノワール★★:なぜって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_00010010")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:エクセリアはここみたいに静かな場所が好きだと思ったから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_00010011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力

	--★★エクセリア★★:確かにこの場所は好きよ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_00010012")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")

	--★★エクセリア★★:ひとりで戦術を考えたり数式を解いたりしたいときに最適だわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_00010013")

-- ▼直接出力
PlayPartVoice("エクセリア", "悩む")
-- ▲直接出力

	--★★エクセリア★★:でも、あなたにそのことは<br>話していなかったはずよ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_00010014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エクセリア", "挨拶")
-- ▲直接出力

	--★★エクセリア★★:どうしてわかったの？参考にしたいわ。聞かせて
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_00010015")

	open_select_window_tag(Actor001,"Normal","CO_101034_00010016","CO_101034_00010017","CO_101034_00010018")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:どうしてって言われてもカンとしか答えようがないなあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_00010020")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("エクセリア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エクセリア★★:カン…？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_00010021")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ごめんこんな答えかたじゃダメだったか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_00010022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:いいえ、違うの以前、アダンに言われた言葉を思い出していたの
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_00010023")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★エクセリア★★:「ときにはカンに頼ってみるのも悪くはない」アダンは笑いながらそう言っていたわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_00010024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("エクセリア", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:そう、カンなのね…参考にさせてもらうわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_00010025")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:（一応、喜んではくれたのかな…？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101034_00010026")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:普段からキミのことを見てるからさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_00010029")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:わかってるつもりだよキミの好きなこととか、好きな場所とか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_00010030")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("エクセリア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エクセリア★★:普段から私のことを見ている…？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_00010031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あっ！？いや、違うぞ！変な意味じゃないぞ、勘違いしないでくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_00010032")

-- ▼直接出力
PlayPartVoice("エクセリア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エクセリア★★:私は他国から来た人間だものねあやしい動きをしないか監視して当然よね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_00010033")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そういう意味でもないんだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_00010034")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★エクセリア★★:部隊を任されることがある立場としてあなたは常に周りの状況を見ているということね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_00010035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:ありがとう、とても参考になったわ私も油断などしないように心がけないと
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_00010036")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あ、ああ…<br>それは良かった…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_00010037")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そんなことより<br>ここで数式を解いたりしてるのか！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_00010040")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:綺麗に数式を解くためには集中が必要なの静かであれば、静かなほどいいわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_00010041")

	change_face(Actor002,"Normal")

	--★★エクセリア★★:あなたもやってみる？ちょうど今、問題を持っているけれど
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_00010042")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あ、いや、今日はいいやまた今度、時間のあるときにやらせてもらうよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_00010043")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★エクセリア★★:そう？わかったわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_00010044")

	goto Block1end

::Block1end::
-- ▼直接出力
kizuna_gaugeup(Actor002,"エクセリア")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(112011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
