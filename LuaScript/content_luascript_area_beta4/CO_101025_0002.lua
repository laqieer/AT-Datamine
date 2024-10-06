-- このluaスクリプトは、CO_101025_0002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112031_01","112031_01_h")
Include("content_adv_advsmall_112031_01","Template112031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",114.8,CharaPos112031_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112031_01,CameraPos112031_01_005)
	Camera002 = SetTemplate("Actor002",-40.1,CharaPos112031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName112031_01,CameraPos112031_01_003)
	InitializeTemplateRandomCamera112031_01()
	InitializeTemplate112031_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112031)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっと…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_00010008")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:ヴォールスなら今日はいないわおかみさんに頼まれて買い付けに行ってる
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_00010009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:その…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_00010010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定3")
-- ▲直接出力

	--★★クレア★★:おかみさんは休憩中のようよ前掛けと手袋が隅に置かれてるから
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_00010011")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:（なんでもお見通しなんだな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101025_00010012")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★クレア★★:好きな場所に座ってゆっくりして私も自由にさせてもらうから
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_00010013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:じゃ、お言葉に甘えて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_00010014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:クレアはよくここに来るのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_00010015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:ええ考えごとをするときなんかにね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_00010016")

	open_select_window_tag(Actor001,"Normal","CO_101025_00010017","CO_101025_00010018","CO_101025_00010019")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:大工房で考えごとをしてるのか！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_00010021")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:鍛冶の音がうるさくて集中できないだろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_00010022")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クレア★★:気にならないわよ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_00010023")

	change_face(Actor002,"Normal")

	--★★クレア★★:集中しているときは外の音なんて耳に入ってこないもの
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_00010024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:逆に鉄を打つ音がちょうどいいリズムになって考えごとがまとまるときだってあるわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_00010025")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:はあ…俺には理解しにくい世界だな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_00010026")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:それはヴォールスの手伝いも兼ねてるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_00010029")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★クレア★★:そうねヴォールスは接客が苦手だから
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_00010030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:お客さんが来ても黙って睨むばかりでなんの注文もせず帰ってしまうこともあるの
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_00010031")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クレア★★:だから私が注文を当ててあげてる
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_00010032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:それが正しい接客なのかはわからないけど確かに俺が来たときもそうだったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_00010033")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クレア★★:ええ、なかなか楽しいのよ頭の体操に丁度いいわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_00010034")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:へえ、そうなのか俺もちょっとやってみようかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_00010037")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.7)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_CO_101025_0002_Iron_Hit")
-- ▲直接出力
-- ▼直接出力
wait_time(3.2)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_00010038")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.1)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:だぁーっ！周りの音がうるさすぎて全然集中できない！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_00010039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クレア★★:そう？このくらいのほうが集中できる気がするのだけど
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_00010040")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("クレア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クレア★★:人にもよるのかしらね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_00010041")

-- ▼直接出力
kizuna_gaugeup(Actor002,"クレア")
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
	load_area_scene_preload(112031)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
