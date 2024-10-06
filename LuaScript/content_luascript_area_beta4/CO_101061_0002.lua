-- このluaスクリプトは、CO_101061_0002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_02","110061_02_h")
Include("content_adv_advsmall_110061_02","Template110061_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_002)
	Camera002 = SetTemplate("Actor002",20,CharaPos110061_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_mcfc_SitController","to Sit01_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_001)
	InitializeTemplateRandomCamera110061_02()
	InitializeTemplate110061_02()
-- ▼直接出力
lookat_delay_weight(Actor001, 0.6, 0.5, 0.6, 0.5,1.0)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
   prop_001    = load_particle("content_prop_10103001", "10103001_PropModel", false, false)
    set_pos(prop_001,{3.3283,0.814,10.584})
    set_rot(prop_001,{0,-89.8,0})
   prop_002    = load_particle("content_prop_10103002", "10103002_PropModel", false, false)
    set_pos(prop_002,{3.336,0.8525,10.584})
    set_rot(prop_002,{0,-110.8,0})
   prop_003    = load_particle("content_prop_10103003", "10103003_PropModel", false, false)
    set_pos(prop_003,{3.3386,0.8904,10.5836})
    set_rot(prop_003,{0,-89.8,0})
   prop_004    = load_particle("content_prop_10103004", "10103004_PropModel", false, false)
    set_pos(prop_004,{2.778,0.813,10.563})
    set_rot(prop_004,{0,-207.7,0})
prop_005    = load_particle("content_prop_10106005", "10106005_PropModel", false, false)
    set_pos(prop_005,{3.067,0.813,10.343})
    set_rot(prop_005,{0,-1.6,0})
-- ▲直接出力
-- ▼直接出力
book_hand = setup_prop_object(10103005)
book_hand_offset = {-0.025, 0.014, -0.019,11.96,-2.45,-11.7}
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
-- ▼直接出力
on_parent(book_hand,Actor002, "Loc_weapon_constrint_L", book_hand_offset)
-- ▲直接出力
-- ▼直接出力
 --黒背景読込
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
 -- 黒背景の表示
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Reading")
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:あれと、これと…あ、こっちも面白そうだな
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_00010008")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:よっと
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_00010009")

-- ▼直接出力
 --白黒終了フェードアウト
CloseTalkWindow()
setup_small_camera_start()
hide_image(BLACK_WHITE_TIME)

se_play("SE_ADV_CO_101061_0002_Book_Put")

on_active(prop_001)
on_active(prop_002)
on_active(prop_003)
on_active(prop_004)
on_active(prop_005)
wait_time(BLACK_WHITE_TIME)
-- ▲直接出力

	--★★ノワール★★:ずいぶんたくさん持ってきたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_00010010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力

	--★★ラロゥ★★:オレひとりじゃこの大図書院には入りにくいからね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_00010011")

	change_face(Actor002,"Smile")

	--★★ラロゥ★★:せっかく潜り込…じゃない、来られたんだ読みたい本を一気に読んじゃおうと思ってさ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_00010012")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:お前がここまで読書が好きだとはなあ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_00010013")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:別に読書が好きなわけじゃないよ知らない知識に触れることが好きなんだ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_00010014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor002, 0.6, 0.5, 0.6, 0.2,1.0)
keep_ik_lookat(Actor002,Actor001,"J_Head")

-- ▲直接出力

	--★★ラロゥ★★:じゃ、オレ、集中したいからしばらく話しかけないで
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_00010015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
lookat_delay_weight_reset(Actor002,0.7)
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:わかった、わかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_00010016")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
wait_time(2.3)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラロゥ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:…うわ、ウソでしょ！？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_00010017")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:どうしたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_00010018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor002, 0.6, 0.5, 0.6, 0.2,1.0)
keep_ik_lookat(Actor002,Actor001,"J_Head")
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:見てよ、ノワールこの本、ページが破かれてる
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_00010019")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:本当だ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_00010020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight_reset(Actor002,0.7)
PlayPartVoice("ラロゥ", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラロゥ★★:いいところだったのにもうサイアクだよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_00010021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101061_00010022","CO_101061_00010023","CO_101061_00010024")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:司書のクリスティーナさんに報告したほうがいいかもしれないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_00010026")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
lookat_delay_weight(Actor002,0.6, 0.5, 0.6, 0.3,1.0)
keep_ik_lookat(Actor002,Actor001,"J_Head")
PlayPartVoice("ラロゥ", "怒り")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:げっ！？やだよ、余計面倒なことになりそう
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_00010027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:オレがここにいることもよく思ってないかもしれないし
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_00010028")

	change_face(Actor001,"Normal")

	--★★ノワール★★:そんなことはないと思うけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_00010029")

-- ▼直接出力
lookat_delay_weight_reset(Actor002,0.7)
PlayPartVoice("ラロゥ", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:ま、報告しないのはよくないと思うしあとでノワールからやっといて
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_00010030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラロゥ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:オレは想像力で補いながらこの本を急いで読んじゃうからさ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_00010031")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:想像力で補えるもんなのか…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_00010032")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにを読んでたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_00010035")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:冒険小説だよたまにはこういうのも悪くないかと思って
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_00010036")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ふーん…………ん？あれ、この本…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_00010037")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:知ってるの？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_00010038")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ああ…懐かしいな小さい頃に母さんが読んでくれた本だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_00010039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:確か、ディナタン…妹が持ってるはずだ今度貸すよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_00010040")

-- ▼直接出力
lookat_delay_weight(Actor002,0.6, 0.5, 0.6, 0.3,1.0)
keep_ik_lookat(Actor002,Actor001,"J_Head")
PlayPartVoice("ラロゥ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:ほんとに？絶対だからね嘘ついたらアンタの部屋、忍び込むから
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_00010041")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:確かに許せないな犯人さがしでもするか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_00010044")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:オレはパス。どうせ見つからないっていつ破られたのかだってわからないんだし
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_00010045")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor002,0.6, 0.5, 0.6, 0.3,1.0)
keep_ik_lookat(Actor002,Actor001,"J_Head")
PlayPartVoice("ラロゥ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:まったく、本を手荒に扱うとかこの学園の生徒の程度が知れちゃうね～
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_00010046")

	change_face(Actor001,"Normal")

	--★★ノワール★★:学園の生徒とは限らないだろお前みたいに潜り込んだ奴がいるのかも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_00010047")

-- ▼直接出力
PlayPartVoice("ラロゥ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:あはは、確かに！
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_00010048")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ま、誰であろうと<br>図書館の本を破るなんて最低だけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_00010049")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
lookat_delay_weight_reset(Actor002,0.7)
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:だよね。大事なことが書かれてたなら<br>本ごと盗っちゃえばいいのにさ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_00010050")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そういうことじゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_00010051")

	goto Block1end

::Block1end::
-- ▼直接出力
kizuna_gaugeup(Actor002,"ラロゥ")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
   load_particle_preload("content_prop_10103001", "10103001_PropModel", false, false)
   load_particle_preload("content_prop_10103002", "10103002_PropModel", false, false)
   load_particle_preload("content_prop_10103003", "10103003_PropModel", false, false)
   load_particle_preload("content_prop_10103004", "10103004_PropModel", false, false)
load_particle_preload("content_prop_10106005", "10106005_PropModel", false, false)
setup_prop_object_preload(10103005)
book_hand_offset = {-0.025, 0.014, -0.019,11.96,-2.45,-11.7}
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
