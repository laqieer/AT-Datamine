-- このluaスクリプトは、MA_01A112_25.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111012_01","111012_01_h")
Include("content_adv_advsmall_111012_01","Template111012_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111012_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111012_01,CameraPos111012_01_002)
	Camera002 = SetTemplate("Actor002",-20,CharaPos111012_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName111012_01,CameraPos111012_01_003)
	Camera003 = SetTemplate("Actor003",20,CharaPos111012_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName111012_01,CameraPos111012_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111012_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName111012_01,CameraPos111012_01_006)
	InitializeTemplateRandomCamera111012_01()
	InitializeTemplate111012_01()
-- ▼直接出力
load_image("10302002", "content_still_10302002_image", "103020020_StillImage")
show_image("10302002", 0.0, 0.0, STILL_SWITCH_TIME ,true,false)
set_enable_auto_lookat_all(false)
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Sad02")
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Sad02")
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Sad02")
change_face(Actor001,"Sad")
change_face(Actor002,"Sad")
change_face(Actor003,"Sad")
change_face(Actor004,"Sad")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111012)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","002","101011002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","002","101018002","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
setup_small_camera_start(RndCamera001)
hide_image(STILL_SWITCH_TIME) 
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
wait_time(2)
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ラグネル", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ラグネル★★:あたしたち<br>朝が好きなのはなんでだっけ
	Talk(Actor004,"CHRNAME_RAGNAR2","speech","L","MA_01A112_250002")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★ノワール★★:え…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_250003")

-- ▼直接出力
set_common_look_at(Actor003,Actor004)
PlayActionDirect(Actor003,"to Std_Loop")
 --PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガウェイン★★:あの人ひとが朝イチで<br>稽古つけてくれてたからだろ？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_250004")

-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat_all(true)
-- ▲直接出力
-- ▼直接出力
change_face(Actor002,"Normal")
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ラグネル★★:…今日みたいにね
	Talk(Actor004,"CHRNAME_RAGNAR2","speech","L","MA_01A112_250006")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ガウェイン★★:………見習うべき背中なんざ、もうねえ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_250008")


	--★★ガウェイン★★:庇い立てもしねえ<br>介錯だってしてやらねえ、けど──
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_250009")

	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガウェイン★★:どっちにしたらいいんだろうな
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_250010")


	--★★ガウェイン★★:「ありがとう」っつーべきか<br>「ざけんな」っつーべきか
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_250011")

-- ▼直接出力
PlayActionDirect(Actor004,"to  Std_Talk")
turn_chara(Actor004,130,0.5)
 --PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力

	--★★ラグネル★★:決まキマってるじゃん
	Talk(Actor004,"CHRNAME_RAGNAR2","speech","L","MA_01A112_250012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ラグネル★★:ガウェインあんたの好きにしなよ
	Talk(Actor004,"CHRNAME_RAGNAR2","speech","L","MA_01A112_250014")

-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Worry")
 --PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:…お前も俺と<br>同じ答えだろ？うよ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_250015")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
change_face(Actor001,"Normal")
change_face(Actor002,"Normal")
 --PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ラグネル★★:あんたはあたし、だもんね？
	Talk(Actor004,"CHRNAME_RAGNAR2","speech","L","MA_01A112_250016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Sad02")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:………信じらんねーえな<br>勝っちまった
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_250018")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★ラグネル★★:ボロ負けしてたのにね
	Talk(Actor004,"CHRNAME_RAGNAR2","speech","L","MA_01A112_250019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A112_250021","MA_01A112_250022","MA_01A112_250023")
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
setup_small_camera_start(Camera001)
set_rot(Actor003,{0,55,0})
set_rot(Actor004,{0,107,0})
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:故郷を守ろうとしたギネヴィアもいたから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_250025")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_end()
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:実家を踏み荒らされて<br>いい気分でいられる人いないもんね
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A112_250026")

-- ▼直接出力
set_common_look_at(Actor002,Actor003)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:でも一番いちばんはガウェインとラグネルだよ<br>外で頑張ってくれた人もいる
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A112_250027")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:エレインが守ってくれたおかげもあるし
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A112_250028")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera001)
set_rot(Actor003,{0,55,0})
set_rot(Actor004,{0,107,0})
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あのとき、エレインが助けてくれたおかげだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_250030")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_end()
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:ああ…スノードンでお前らがヤられてたら<br>ここまで来られてねえ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_250031")

-- ▼直接出力
 --PlayPartVoice("ラグネル", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ラグネル★★:お見舞い行こ、ぜったい
	Talk(Actor004,"CHRNAME_RAGNAR2","speech","L","MA_01A112_250032")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera001)
set_rot(Actor003,{0,55,0})
set_rot(Actor004,{0,107,0})
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ガウェインたちが力を尽くしてくれたおかげだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_250034")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_end()
 --PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:背水の陣ってやつだな<br>学園に指一本触れさせるわけにはいかねえ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_250035")

-- ▼直接出力
 --PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ラグネル★★:ヴェルナルスにもね<br>やられっぱなしじゃいられなかったもん！
	Talk(Actor004,"CHRNAME_RAGNAR2","speech","L","MA_01A112_250036")

	change_face(Actor003,"Normal")

	--★★ガウェイン★★:…借り、返せたよな<br>ヴェルナルスには
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_250037")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
change_face(Actor002,"Normal")
change_face(Actor003,"Normal")
change_face(Actor004,"Normal")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それにきっと、ラシアも言ってたけど<br>GSが絆を力にしてるというなら──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_250039")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:…ともに生きた時、想いの強さ、覚悟の重み<br>それが結ぶ絆こそGSのチカラ…
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A112_250041")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:そうか！<br>今はみっつも絆があんだ！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_250042")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:ひとつ！俺とラグネルは<br>幼いころからいっしょで絆は深ぇ！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_250044")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ガウェイン★★:ふたつ！<br>俺たち全員が初めて絆を結んだのがココ！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_250045")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:みっつ！<br>ギネヴィアにとっても絆が忘れらんねえ故郷！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_250046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:チカラになっていたんだ、きっと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_250047")

-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Sad01")
 --PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ガウェイン★★:チカラ、3倍くらいにはなったよな？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_250048")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("10302002", "content_still_10302002_image", "103020020_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(111012)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","002","101011002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","002","101018002","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111012_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
