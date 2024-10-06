-- このluaスクリプトは、CO_101026_0002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_004)
	Camera002 = SetTemplate("Actor002",186.57,CharaPos110061_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_002)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002, 0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:………
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_00010008")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:キョロキョロしてどうした？なにか気になることでもあるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_00010009")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor001, 0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:え？あ、ああ空いている席を探していたのさ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_00010010")


	--★★パーシヴァル★★:今日はちょっと疲れていてね静かな場所でゆっくりしたいと思っていたんだ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_00010011")

-- ▼直接出力
setup_small_camera_end()
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:ぼくを接待する場所に大図書館を選んだキミの心遣いに敬意を表しておこう
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_00010012")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうか（接待してるつもりじゃないんだけどな）
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_00010013")


	--★★ノワール★★:読みたい本があるなら持ってこようか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_00010014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:いや、結構
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_00010015")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定")
-- ▲直接出力

	--★★パーシヴァル★★:ぼくの故郷にも大きな図書館があってねここにあるような本はあらかた読んでしまった
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_00010016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:ふーん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_00010017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101026_00010018","CO_101026_00010019","CO_101026_00010020")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:恥ずかしながら俺、学園に来るまで本なんて借りたことなくてさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_00010022")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:オススメの本があったら教えてくれないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_00010023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:ふむ。庶民は勤勉であるべき貴族は庶民に知見を共有するべきというやつだな
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_00010024")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:聞いたことないぞそんな言葉
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_00010025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "悩む")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:…そうだな、これなんかどうだい？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_00010026")

	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:この世界に語り継がれてきた伝承についてまとめられた本だよ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_00010027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ふーん…って、これ絵本じゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_00010028")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:キミのレベルにはちょうどいいだろう
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_00010029")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:それに、こういう平易な言葉で書かれた本にこそ得てして真実が書かれているものなのさ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_00010030")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:ぼくも幼い頃からこういった本をたくさん読み聞かせてもらったものだよ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_00010031")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:へえ、誰に？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_00010032")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:い、今は誰に読んでもらったかは今は関係ないだろう！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_00010033")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:庶民はつまらないことなど気にせず一心不乱に読めばいいんだ！さあ！さあ！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_00010034")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:そういえばディンドランさん、いないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_00010037")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:受付にいないときは奥にある部屋で書類整理をしていることが多い
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_00010038")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:屋上や遺跡あたりに行って<br>休憩していることもあるな
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_00010039")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…詳しいんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_00010040")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "照れ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:ま、まあ、一応は姉弟だからな<br>キミだって妹のことはそれなりに見ているだろ？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_00010041")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや？あんまり…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_00010042")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:薄情な兄だな、キミは…庶民の家庭とはそういったものなのか？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_00010043")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:庶民とか貴族とかは関係ないと思うけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_00010044")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:よくここで休んでるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_00010047")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:よく、というほどではないがね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_00010048")

	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:昔から気持ちを落ち着かせるときは図書館に行っていたから、その流れだよ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_00010049")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:昔から図書館に行ってたって？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_00010050")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:ああぼくの故郷にも大きな図書館があったんだ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_00010051")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:ここにも負けない世界でも有数の蔵書量を誇る図書館がね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_00010052")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:………
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_00010053")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:パーシヴァル？どうかしたか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_00010054")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:…別に。なんでもないよ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_00010055")

	goto Block1end

::Block1end::
-- ▼直接出力
kizuna_gaugeup(Actor002,"パーシヴァル")
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
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
