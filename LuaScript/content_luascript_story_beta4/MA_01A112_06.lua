-- このluaスクリプトは、MA_01A112_06.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_006)
	Camera002 = SetTemplate("Actor002",80,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	Camera003 = SetTemplate("Actor003",-100,CharaPos110122_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110122_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_001)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
set_pos(Actor004,{0.91,0,-14.67})
set_rot(Actor004,{0,-25,0})
Hide(Actor004)
set_enable_auto_lookat(Actor001,false)
set_enable_auto_lookat(Actor002,false)
keep_ik_lookat(Actor001,Actor003,"J_Head")
keep_ik_lookat(Actor002,Actor003,"J_Head")
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(3,false)
setup_template_moveobj_110122_01(7,false)
setup_template_moveobj_110122_01(8,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★ガウェイン★★:…奢らせてくんねーか、ラヴェイン
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A112_060002")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "否定")
-- ▲直接出力

	--★★ラヴェイン★★:…そういうのは止めましょう、ガウェイン君
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A112_060003")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:スノードンで<dot>ヴェルナルス</dot>と戦ったとき<br>俺らが助けに入れたのは…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A112_060004")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ガウェイン★★:ラヴェインが道を拓いたからだ<br>あんたがいなかったらと思うとゾッとするぜ…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A112_060006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:あんたの強さ<br>円卓の騎士になってたって不思議じゃねえ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A112_060007")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "肯定2")
-- ▲直接出力

	--★★ラヴェイン★★:ああ…お断りしたのです。随分前に<br>大変申し訳ないことでしたが
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A112_060008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
change_face(Actor002,"Surprise")
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:誘いがあったのか…！？<br>どうして断ったんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_060010")

-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "肯定")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ラヴェイン★★:エレインが<br>ああならないようにです
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A112_060011")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラヴェイン★★:…まあ事情は色々、語るのはおいおい<br>機会があれば…としたいのですが──
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A112_060013")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラヴェイン★★:誰かが救いを求める声よりも家族を最優先します<br>わがままなんですよ私は。幻滅でしょう？
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A112_060014")

-- ▼直接出力
change_face(Actor001,"Normal")
change_face(Actor002,"Normal")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラヴェイン★★:ノワール君。貴方のような救世主にはなれない<br>そしてガウェイン君のような忠義者でもない
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A112_060015")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:…忠義者、俺が…？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A112_060017")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "肯定2")
-- ▲直接出力

	--★★ラヴェイン★★:アーサー王に忠を誓いながら<br>恩師ヴェルナルス大将軍との対峙を恐れている
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A112_060018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガウェイン★★:だ、誰が、誰が恐れてるってんだよ…！<br>俺は別に師匠なんかなァッ…！！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A112_060019")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラヴェイン★★:私なら怖くてその場から離れてしまいますよ<br>誓いなど放り、恩師との対話など避けて
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A112_060020")

-- ▼直接出力
set_enable_auto_lookat_all(false)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラヴェイン★★:ガウェイン君は一度として<br>そんな素振りを見せましたか、ノワール君？
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A112_060021")

	open_select_window_tag(Actor001,"Normal","MA_01A112_060023","MA_01A112_060024","MA_01A112_060025")
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
lookat_weight(Actor002,0.7,0.03,0.7,0)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1)
change_face(Actor002,"Normal")
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:何度も立ち向かっていたよ、ガウェインは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_060027")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラヴェイン★★:そう。正面から、一度として退くことなく<br>真っすぐに立ち向かっていました
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A112_060028")

	change_face(Actor003,"Normal")

	--★★ラヴェイン★★:主への忠義と、師への忠義<br>どちらにもぶつかっていっていました
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A112_060029")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:及び腰になっていたことも<br>あったかな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_060031")

-- ▼直接出力
lookat_weight(Actor002,0.7,0.03,0.7,0)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",2)
 --PlayPartVoice("ガウェイン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:ノワール酷ぇぞ！！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A112_060032")

	change_face(Actor002,"Sad")

	--★★ガウェイン★★:そりゃちょっと<br>オチることくらいあるけどよぉ………
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A112_060033")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
lookat_weight(Actor002,0.7,0.03,0.7,0)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1)
change_face(Actor002,"Normal")
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:さっきの話だが<br>俺にも奢らせてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_060035")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "否定")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラヴェイン★★:いつの話をしているんですか<br>戦場においてはお互い様ですよ
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A112_060036")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:俺の話題、そんなにキョーミねえ…？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A112_060037")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(RndCamera003)
change_face(Actor001,"Normal")
change_face(Actor003,"Normal")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003,true)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",0.5)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:…師匠はさ、俺らのことなんか<br>眼中にねーんだよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A112_060039")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:喧嘩ってのは相手もコッチ向いてねえと<br>ちゃんと成立しねーんだって…わかったぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A112_060040")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera002)
lookat_delay_weight(Actor003,0.7,0.03,0.7,0,1)
Appear(Actor004)
keep_ik_lookat(Actor004,Actor002,"J_Head")
PlayActionDirect(Actor004,"to Wlk")
slidemove(Actor004,{-0.1,0,-12.5},1.5)
wait_time(1.3)
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力

	--★★ラグネル★★:暗いカオすんなよ、ガウェイン
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A112_060042")

-- ▼直接出力
CameraEX = set_camera({-0.77, 1.17, -10.85, 0, -195.5, 0, 42})
setup_small_camera_start(CameraEX)
slidemove(CameraEX,{-0.77, 1.2, -10.85},5.0)
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",1)
-- ▲直接出力

	--★★ガウェイン★★:お互いサマだろ、ラグネル
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A112_060044")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
set_animationcontroller(Actor004,"Com_f_SitController","to Sit01_Loop")
Camera004=setup_small_camera_resetting(Actor004,CharaPos003,CameraPos003)
set_common_look_at(Actor001,Actor004)
set_common_look_at(Actor002,Actor004)
set_common_look_at(Actor003,Actor004)
set_common_look_at(Actor004,Actor002)
setup_small_camera_start(RndCamera004)
change_face(Actor001,"Normal")
setup_template_moveobj_110122_01(3,true)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラグネル", "挨拶")
-- ▲直接出力

	--★★ラグネル★★:ガウェインが言ったんだよ
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A112_060045")


	--★★ラグネル★★:「あたしの好きにしていい」って<br>だからあたし、ずっと考えてた
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A112_060047")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Sad")

	--★★ラグネル★★:でもね、答え出ないんだ<br>出る考えと言ったら逃げ腰なものばっかり
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A112_060048")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor002)
lookat_weight(Actor004,0.5,0.03,0.7,0)
 --PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力

	--★★ガウェイン★★:…俺もだよ、なっさけねえ<br>タンカ切ったくせに何度喧嘩の機会逃してんだろ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A112_060049")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(true)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラヴェイン★★:ガウェイン君、ラグネルさん<br>私が見ているかぎり貴方たちとその師には──
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A112_060050")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "肯定")
-- ▲直接出力

	--★★ラヴェイン★★:断ち切れない憧れがある<br>切っても切れない縁がある
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A112_060051")


	--★★ラヴェイン★★:ならばそれは手繰り寄せられるはず<br>貴方たちにはその姿勢がある、覚悟がある
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A112_060052")


	--★★ラヴェイン★★:日向に居続ける選択をした円卓の騎士ならば
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A112_060053")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "悩む")
-- ▲直接出力

	--★★ラヴェイン★★:ゆえに逃げ腰になっているのは<br>ヴェルナルス将軍です
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A112_060054")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
change_face(Actor004,"Surprise")
 --PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:し、師匠が、逃げてる…？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A112_060055")

-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "肯定2")
-- ▲直接出力

	--★★ラヴェイン★★:なぜかわかりますか？
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A112_060056")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
lookat_weight(Actor001,0.6,0.03,0.7,0)
lookat_weight(Actor002,0.7,0.03,0.7,0)
 --PlayPartVoice("ラグネル", "悩む")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ラグネル★★:………ちょっと<br>咀嚼する時間が欲しいね…
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A112_060057")

-- ▼直接出力
setup_small_camera_start(Camera002)
set_enable_auto_lookat(Actor001,false)
set_enable_auto_lookat(Actor002,false)
set_enable_auto_lookat(Actor004,false)
keep_delay_ik_lookat(Actor004,Actor002,"J_Head",1)
 --PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力

	--★★ガウェイン★★:そしゃく？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A112_060058")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1)
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:噛み砕いて消化すること
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_060059")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1)
 --PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:メシ食わねーと<br>正解わかんねえってことか
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A112_060060")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ラグネル★★:…合ってるんじゃない？ある意味
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A112_060062")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Hide(Actor002)
Hide(Actor004)
change_face(Actor003,"Anger")
set_enable_auto_lookat_all(false)
set_rot(Actor003,{0,-90,0})
lookat_delay_weight_reset(Actor001,1)
lookat_delay_weight_reset(Actor003,1)
setup_small_camera_start(RndCamera004)
setup_template_moveobj_110122_01(3,false)
setup_template_moveobj_110122_01(4,false)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ラヴェイン★★:ノワール君、私から貴方に<br>折り入ってご相談が
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A112_060064")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラヴェイン★★:…妹を、救ってくれませんか
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A112_060065")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
