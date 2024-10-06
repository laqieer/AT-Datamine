-- このluaスクリプトは、CO_101014_0302.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_02","110061_02_h")
Include("content_adv_advsmall_110061_02","Template110061_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",15,CharaPos110061_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_002)
	InitializeTemplateRandomCamera110061_02()
	InitializeTemplate110061_02()
-- ▼直接出力
   prop_001    = load_particle("content_prop_10103001", "10103001_PropModel", false, false)
    set_pos(prop_001,{4.0527,0.814,10.581})
    set_rot(prop_001,{0,-89.8,0})
   prop_002    = load_particle("content_prop_10103002", "10103002_PropModel", false, false)
    set_pos(prop_002,{4.0604,0.8525,10.581})
    set_rot(prop_002,{0,-110.8,0})
   prop_003    = load_particle("content_prop_10103003", "10103003_PropModel", false, false)
    set_pos(prop_003,{4.063,0.8904,10.581})
    set_rot(prop_003,{0,-89.8,0})
   prop_004    = load_particle("content_prop_10103004", "10103004_PropModel", false, false)
    set_pos(prop_004,{3.729,0.813,10.611})
    set_rot(prop_004,{0,-207.7,0})
prop_005    = load_particle("content_prop_10106005", "10106005_PropModel", false, false)
    set_pos(prop_005,{3.936,0.813,10.351})
    set_rot(prop_005,{0,-1.6,0})
prop_006    = load_particle("content_prop_10106005", "10106005_PropModel", false, false)
    set_pos(prop_006,{3.183,0.813,10.351})
    set_rot(prop_006,{0,-1.6,0})
prop_007    = load_particle("content_prop_10106006", "10106006_PropModel", false, false)
    set_pos(prop_007,{3.387,0.827,10.509})
prop_008    = load_particle("content_prop_10106006", "10106006_PropModel", false, false)
    set_pos(prop_008,{4.226,0.827,10.423})
on_active(prop_001)
on_active(prop_002)
on_active(prop_003)
on_active(prop_004)
on_active(prop_005)
on_active(prop_006)
on_active(prop_007)
on_active(prop_008)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002,Actor001, "J_Head")
keep_ik_lookat(Actor001,Actor002, "J_Head")
set_common_look_at(Actor002,Actor001)
-- ▲直接出力
-- ▼直接出力
note = setup_prop_object(10106001)
set_pos(note,{4.185, 0.817, 10.435})
set_rot(note,{0,180,0})
book = setup_prop_object(10103003)
set_pos(book,{3.885, 0.817, 10.435})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:詩ってどうやって書けばいいんだ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03020002")


	--★★ノワール★★:なんにも思いつかないしまるでできる気がしない…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03020003")

	open_select_window_tag(Actor001,"Normal","CO_101014_03020005","CO_101014_03020006","CO_101014_03020007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
set_common_look_at(Actor001,Actor002)
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ここにマルディサントがいてくれたらな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03020009")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "激怒")
set_common_look_at(Actor002,Actor001)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:いもしない人の力をあてにしてないでさっさと手を動かしたら？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03020010")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:キミのパートが未完成でもボクは無視して提出するからね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03020011")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
set_common_look_at(Actor002,Actor001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺、詩の作りかたとか全然わからなくてさコツを教えて欲しい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03020013")

	change_face(Actor001,"Normal")

	--★★ノワール★★:よく使われる言い回しとかそういうの、あったりしないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03020014")

-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0025")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:一応自分でやろうとしてる姿勢は認めるけどさ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03020016")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★トリスタン★★:ラクしようと思って作ったものに人は高い評価をしてくれないよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03020017")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
set_common_look_at(Actor002,Actor001)
voice_play("VO_101009_sp_0006_1")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なあ。詩を作るためのパートナーにどうして俺を選んだんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03020019")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:消去法
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03020020")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:イゾルデだといつも一緒にいるから新しい着想を得にくいだろうし
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03020021")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:ガウェインはそもそもうるさすぎて詩を作る空気にならない
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03020022")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、なるほどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03020023")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to Sit01_Loop")
	change_face(Actor002,"Normal")

	--★★トリスタン★★:音楽や絵なんかと同じく詩にも理論や形式はある
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03020025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★トリスタン★★:だけど、芸術っていうのは人の心を癒し慰めるために生み出されたものだ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03020026")


	--★★トリスタン★★:理論や形式をなぞって形だけ整えたってなんの意味も価値もないものしか生まれない
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03020027")


	--★★トリスタン★★:ちゃんとした芸術――今で言うなら詩を作ろうと思ったら
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03020028")


	--★★トリスタン★★:キミの気持ちや思いを乗せて言葉を紡がないと他の人の心に響かないよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03020029")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺の気持ちや思いを乗せる…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03020030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:ディナタンや学園のみんな、仲間への気持ちをあらためて言葉にする、みたいな感じかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03020031")

-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:なんだか気恥しいけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03020033")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★トリスタン★★:そうやって恥ずかしがってたら伝わるものも伝わらないよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03020034")


	--★★トリスタン★★:課題とはいえボクと組む以上は半端なものなんか許さないから
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03020035")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★トリスタン★★:恥なんか捨てて真面目にやってよね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03020036")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:ウッ、はい…頑張ります…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03020037")

	change_face(Actor001,"Normal")

	--★★ノワール★★:（芸術は人の心を癒し慰めるためのもの、か）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101014_03020039")

-- ▼直接出力
setup_small_camera_end()
lookat_delay_weight_default(Actor001, 1)
keep_ik_lookat(Actor001, Actor002, "J_Head")
-- ▲直接出力

	--★★ノワール★★:（トリスタンの竪琴も誰かの心を癒すために奏でてるのかな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101014_03020040")

-- ▼直接出力
PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:なに見てるの？手、止まってるよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03020042")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★トリスタン★★:聞きたいことがあるなら口で言ってくれる？無言の訴えを気にするほど暇じゃないから、ボク
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03020043")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:な、なんでもないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03020044")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_トリスタン_ランクアップ3_3")
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
load_particle_preload("content_prop_10106005", "10106005_PropModel", false, false)
load_particle_preload("content_prop_10106006", "10106006_PropModel", false, false)
load_particle_preload("content_prop_10106006", "10106006_PropModel", false, false)
setup_prop_object_preload(10106001)
setup_prop_object_preload(10103003)
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
