-- このluaスクリプトは、CO_101025_0802.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110161_02","110161_02_h")
Include("content_adv_advsmall_110161_02","Template110161_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110161_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110161_02,CameraPos110161_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110161_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110161_02,CameraPos110161_02_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110161_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110161_02,CameraPos110161_02_004)
	InitializeTemplateRandomCamera110161_02()
	InitializeTemplate110161_02()
-- ▼直接出力
Prop_01 = get_object("geo_desk_item_09")
set_pos(Prop_01, {0,0,1.6})
Prop_02 = get_object("geo_chair_14")
set_pos(Prop_02, {1.05,0,3.13})
set_rot(Prop_02,{0,0,0})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor003,Actor001,"J_Head")
lookat_weight_default(Actor001)
lookat_weight_default(Actor003)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110161)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:それで…<br>ジャスパーの行き先の見当というのは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_08020002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:探偵の心得よ<br>仮説を立ててみましょう
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_08020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to Finger")

	--★★クレア★★:ジャスパーは自分が<br>『血の蒐集家』であると思わせたい
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_08020004")


	--★★クレア★★:そのためには<br>なるべく騒ぎを大きくしたい
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_08020005")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ヴォールス★★:誰もいないところで事件を起こしても<br>話題にならないというわけだな
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_08020006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定3")
-- ▲直接出力

	--★★クレア★★:そう<br>つまりはどういうことかわかる？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_08020007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101025_08020009","CO_101025_08020010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ひょっとして…ジャスパーは<br>すぐ近くに潜んでいるんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_08020012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:おそらくそうよ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_08020013")

	change_face(Actor002,"Normal")

	--★★クレア★★:ジョーイの母親の<br>取り乱しようを見たでしょう？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_08020014")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★クレア★★:街のなかでジョーイを殺害すれば<br>大騒ぎになることは間違いないわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_08020015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ご、ごめん、わからない<br>どういうことだろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_08020017")

-- ▼直接出力
PlayPartVoice("クレア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:…ジャスパーは<br>街のなかで事件を起こそうとしている
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_08020018")

	change_face(Actor002,"Normal")

	--★★クレア★★:潜伏場所は<br>この街から遠く離れていないはずよ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_08020019")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ジャスパーの居場所は絞り込めたけど<br>特定にまでは至れていないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_08020021")

	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ヴォールス", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ヴォールス★★:ここからが大変だな<br>うーむ、どうしたものか
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_08020022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101025_08020024","CO_101025_08020025")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Sad02")
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:猫の手でも借りたいってのは<br>このことだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_08020027")

-- ▼直接出力
PlayPartVoice("クレア", "否定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クレア★★:…そうか、その手があったわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_08020028")

-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_08020029")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("クレア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クレア★★:猫じゃないけど<br>ジョーイと仲の良い動物がいたでしょう
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_08020030")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ああっ、スコーンか！<br>犬なら鼻が利く！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_08020031")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:あのさ。スコーンっていただろ？<br>ジョーイたちが可愛がってた犬
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_08020033")

	change_face(Actor001,"Normal")

	--★★ノワール★★:近くにいるなら<br>あいつの鼻で探せないかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_08020034")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クレア★★:おもしろいアイデアね<br>試してみる価値はありそう
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_08020035")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat(Actor003,true)
change_face(Actor002,"Normal")
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:母親の所に行って<br>ジョーイのにおいのついたものを貸してもらおう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_08020037")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_クレア_ランクアップ8_3")
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
	load_area_scene_preload(110161)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110161_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
