-- このluaスクリプトは、MA_01C109_26.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110122_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110122_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_002)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor003, Actor002, "J_Head")
lookat_delay_weight(Actor003,1.0,0.02,0.4,0,1.0)
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(3,false)
setup_template_moveobj_110122_01(4,false)
setup_template_moveobj_110122_01(5,false)
setup_template_moveobj_110122_01(6,false)
setup_template_moveobj_110122_01(7,false)
setup_template_moveobj_110122_01(8,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ガウェイン","挨拶")
-- ▲直接出力

	--★★ガウェイン★★:あのさ、ノワール借りてもいいか？<br>メシ終わったら
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01C109_260002")

-- ▼直接出力
lookWeight = {0.9, 0, 0.4, 0.35}
lookat_delay_weight(Actor001, lookWeight,2)
keep_ik_lookat(Actor001, Actor003, "J_Head")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン","驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:え？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_260003")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:ちゃんと返すからさ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01C109_260004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:いいですよ？<br>貸し出しますっ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_260006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C109_260007","MA_01C109_260008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:大した用じゃないんだろ？どうせ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_260010")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン","照れ")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:バレた？そうなんだよ<br>ちょっと聞きてーことがあったんだけどさ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01C109_260011")

-- ▼直接出力
 --DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor003)
 --DontChangeRandomCamera(true)
Appear(Actor005)
lookat_delay_weight_reset(Actor003 , 0.5)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:ま、改まってするハナシでもねーや<br>忘れてくれ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01C109_260012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:大事な話か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_260014")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン","肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:ん、まあちょっとな<br>聞きてーことがあってさ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01C109_260015")

-- ▼直接出力
 --DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor003)
 --DontChangeRandomCamera(true)
Appear(Actor005)
lookat_delay_weight_reset(Actor003 , 0.5)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガウェイン","悩む")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:いや、そんなかしこまったモンでもねーんだ<br>ちょっと…なんとなく気になったことがあってさ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01C109_260016")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(Camera005)
setup_template_moveobj_110122_01(3,true)
setup_template_moveobj_110122_01(4,true)
lookat_delay_weight_reset(Actor001 , 0.5)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("リオネス","笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★リオネス★★:おまちどー！<br>兄妹仲良くＡランチを２つ！
	Talk(Actor005,"CHRNAME_LYONESS","speech","L","MA_01C109_260018")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, 0.6)
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01C109_26_Food_Tray")
-- ▲直接出力
-- ▼直接出力
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
fadein(0.6)
wait_time(0.6+0.6)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン","驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:わ。できたて？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_260019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("リオネス","肯定2")
-- ▲直接出力

	--★★リオネス★★:できたてもほやほや！！
	Talk(Actor005,"CHRNAME_LYONESS","speech","L","MA_01C109_260020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガウェイン","驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:…あり？俺の<br>ガウェインスペシャルワンプレートは？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01C109_260021")

	change_face(Actor005,"Normal")

	--★★リオネス★★:おまえのは後回しだ
	Talk(Actor005,"CHRNAME_LYONESS","speech","L","MA_01C109_260022")

-- ▼直接出力
setup_small_camera_start(Camera003)
Appear(Actor004)
-- ▲直接出力
	PlayAction(Actor003,"to Sit01_RH01")
-- ▼直接出力
 --PlayPartVoice("ガウェイン","怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ガウェイン★★:あんでだよっ！？<br>こいつらと一緒に頼んだだろうが！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01C109_260023")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat(Actor003, true)
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガレス","落胆")
-- ▲直接出力

	--★★ガレス★★:兄さんの注文は時間がかかるんだ<br>作ってるとほかのお客さんの料理が遅れてしまう
	Talk(Actor004,"CHRNAME_GARETH","speech","L","MA_01C109_260025")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン","悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガウェイン★★:兄妹ってことで、俺のを優先的に頼む！<br>なっ？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01C109_260026")

-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("リオネス","落胆")
-- ▲直接出力

	--★★リオネス★★:そこは兄妹なら<br>妹のためを想ってガマンでしょ
	Talk(Actor005,"CHRNAME_LYONESS","speech","L","MA_01C109_260027")

-- ▼直接出力
 --PlayPartVoice("ガレス","悲しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ガレス★★:ノワールとディナタンが羨ましいな～<br>わたしも優しい兄さんが良かった
	Talk(Actor004,"CHRNAME_GARETH","speech","L","MA_01C109_260028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C109_260029","MA_01C109_260030")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ガウェインとガレスだって<br>じゅうぶん仲が良いじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_260032")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("リオネス","笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★リオネス★★:あたしもそう思うぞ！
	Talk(Actor005,"CHRNAME_LYONESS","speech","L","MA_01C109_260033")

-- ▼直接出力
 lookat_delay_weight_reset(Actor003 , 1)
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★リオネス★★:スペシャルワンプレートなんて<br>ガウェインにしか用意してないしな！
	Talk(Actor005,"CHRNAME_LYONESS","speech","L","MA_01C109_260034")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:泣かせるじゃねーの、妹よ！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01C109_260035")

-- ▼直接出力
 --PlayPartVoice("ガレス","悲しみ")
-- ▲直接出力
	change_face(Actor004,"Shy")

	--★★ガレス★★:「兄貴だから」って変な注文の仕方するから<br>用意してあるだけだよ
	Talk(Actor004,"CHRNAME_GARETH","speech","L","MA_01C109_260036")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール","照れ")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そう言われると照れるなあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_260038")

-- ▼直接出力
lookat_delay_weight_reset(Actor003 , 1)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン","照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:て、照れちゃうね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_260039")

	change_face(Actor003,"Sad")

	--★★ガウェイン★★:あーなんか冷めるわー、メシが<br>ごちそうさーん
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01C109_260040")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガウェイン","落胆")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:仲良くしてくれる家族ばっかじゃねーってのが<br>世知辛いっつーか、なんつーか
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01C109_260042")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("リオネス","落胆")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★リオネス★★:わかってないな、ガウェイン
	Talk(Actor005,"CHRNAME_LYONESS","speech","L","MA_01C109_260043")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:わーってるよ<br>俺は後回しだってんだろ？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01C109_260045")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("リオネス","悩む")
-- ▲直接出力

	--★★リオネス★★:できたてを食べて欲しいんだよ、ガレスは
	Talk(Actor005,"CHRNAME_LYONESS","speech","L","MA_01C109_260046")

	change_face(Actor005,"Smile")

	--★★リオネス★★:だから面倒くさくても<br>作り置きとかしないんだ
	Talk(Actor005,"CHRNAME_LYONESS","speech","L","MA_01C109_260048")

	change_face(Actor003,"Normal")

	--★★ガウェイン★★:………
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01C109_260049")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat_all(true)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガレス","挨拶")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ガレス★★:ディナタン、ひとつ忠告だ<br>甘えられるときに甘えておいたほうがいいぞ
	Talk(Actor004,"CHRNAME_GARETH","speech","L","MA_01C109_260051")

-- ▼直接出力
 --PlayPartVoice("ディナタン","驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:えっ？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_260052")


	--★★ガレス★★:兄さんはわたしが小さいときに<br>家を追い出された
	Talk(Actor004,"CHRNAME_GARETH","speech","L","MA_01C109_260053")

-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガウェイン","落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガウェイン★★:い、言いかたに気を付けてくれよ<br>勘当されたみたいだろ、オレが
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01C109_260054")

	change_face(Actor004,"Sad")

	--★★ガレス★★:わたしが兄さんと再会できたのは<br>それから何年も経ってからだ
	Talk(Actor004,"CHRNAME_GARETH","speech","L","MA_01C109_260055")

	PlayAction(Actor004,"to  Std_Sad01")

	--★★ガレス★★:ずっとずっと寂しい思いをした<br>家族は近くにいなくちゃダメなんだ
	Talk(Actor004,"CHRNAME_GARETH","speech","L","MA_01C109_260056")

	change_face(Actor004,"Normal")

	--★★ガレス★★:ノワール、ディナタンのそばにいてやってくれ<br>きっと心配はないだろうけど
	Talk(Actor004,"CHRNAME_GARETH","speech","L","MA_01C109_260057")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガレス","笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ガレス★★:妹はそれが嬉しいんだ。な？
	Talk(Actor004,"CHRNAME_GARETH","speech","L","MA_01C109_260059")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン","肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:………うんっ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_260061")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat_all(false)
 --[[
lookat_delay_weight_reset(Actor003 , 1)
lookat_delay_weight_reset(Actor005 , 0.5)
lookat_delay_weight_reset(Actor004 , 1)
lookat_delay_weight_reset(Actor002 , 1)
lookat_delay_weight_reset(Actor001 , 1)
 --]]
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Surprise")

	--★★リオネス★★:そういえば話をさえぎってしまったな！<br>どうぞどうぞ続きをどうぞ！
	Talk(Actor005,"CHRNAME_LYONESS","speech","L","MA_01C109_260062")

-- ▼直接出力
 --PlayPartVoice("ガレス","悩む")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ガレス★★:なんの話をしてたんだ？
	Talk(Actor004,"CHRNAME_GARETH","speech","L","MA_01C109_260063")

-- ▼直接出力
 --PlayPartVoice("ガウェイン","驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:なんだっけ？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01C109_260064")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン","挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:兄さんに聞きたいことがあるとか
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_260065")

	change_face(Actor003,"Normal")

	--★★ガウェイン★★:あー
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01C109_260066")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン","喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:メシの感想、だったかな
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01C109_260067")

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
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
