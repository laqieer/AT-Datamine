-- このluaスクリプトは、EA_009_022.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_02_009,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_009)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110141_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110141_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_006)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
-- ▼直接出力
set_pos(Actor001,{-2.37,0,2.05})
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor002,0.6,0.1,0.9,0.2)
keep_ik_lookat(Actor002,Actor003,"J_Head")
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor003,0.6,0.1,0.85,0.2)
keep_ik_lookat(Actor003,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor004,0.65,0.1,0.9,0.2)
keep_ik_lookat(Actor004,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005,{-2.05,0,2.3})
Hide(Actor005)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayActionDirect(Actor001,"to Run")
turn_lookat_position(Actor001,CharaPos110141_02_004[1],CharaPos110141_02_004[2],CharaPos110141_02_004[3],0)
slidemove(Actor001,CharaPos110141_02_004[1],CharaPos110141_02_004[2],CharaPos110141_02_004[3],1.4)
wait_time(1.4)
setup_small_camera_start(Camera001)
PlayActionDirect(Actor001,"to Std_Loop")
turn_chara(Actor001,CharaPos110141_02_004[4],0.1)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
wait_time(0.5)
PlayActionDirect(Actor004,"to Wlk")
turn_chara(Actor004,198,0.2)
wait_time(0.2)
PlayActionDirect(Actor004,"to Std_Loop")
keep_ik_lookat(Actor004,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101009_sp_0003_2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ディナタン！！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0220006")

-- ▼直接出力
CloseTalkWindow()
set_enable_auto_lookat(Actor002, false)
turn_chara(Actor003,175,0)
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor001,"J_Head")
set_enable_auto_lookat(Actor004, false)
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:！！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_009_0220007")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0007")
-- ▲直接出力

	--★★イゾルデ★★:来たわね。ちょうどよかったわ<br>今から私の診断を伝えるところよ
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","EA_009_0220008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:診断…ディナタンの容態はどうなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0220009")

-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0034")
-- ▲直接出力

	--★★イゾルデ★★:身体に異常は見られないわ<br>喉も見たけど、とくに腫れた様子もない
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","EA_009_0220010")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★イゾルデ★★:<dot>声が出ない</dot>という1点を除けば<br>むしろ健康そのものね
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","EA_009_0220011")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:声が出ない！？<br>なんだってそんなことに…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0220013")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マルディサント","0024")
-- ▲直接出力

	--★★マルディサント★★:それがわかんねぇんだよ<br>いったいどうなってんだ！？
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","EA_009_0220014")

	PlayAction(Actor004,"to  Std_Sad02")
	change_face(Actor004,"Sad")

	--★★マルディサント★★:街の外にバルバロイをぶっ倒しに行くまでは<br>なんともなかったってのに
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","EA_009_0220015")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera003)
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1.0)
wait_time(0.5)
set_enable_auto_lookat(Actor002, true)
set_enable_auto_lookat(Actor004, true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0007")
-- ▲直接出力

	--★★イゾルデ★★:身体に問題が無いとすると<br>原因は他にありそうだけれど…心当たりはある？
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","EA_009_0220016")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera002)
wait_time(0.2)
play_head_motion(Actor002, "No", 0.3, 1.0, false)
wait_time(2.7)
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0008")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★イゾルデ★★:そう<br>なら、私にできることはないわね
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","EA_009_0220019")

-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
-- ▲直接出力

	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_009_0220021")

-- ▼直接出力
setup_small_camera_start()
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("マルディサント","0019")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★マルディサント★★:なんだよそれ！いつもみたいにヤクソーで<br>チャチャッと治してくれよ！！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","EA_009_0220022")

	change_face(Actor003,"Normal")

	--★★イゾルデ★★:私も万能ではないの<br>原因がわからなければ対処のしようがないわ
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","EA_009_0220023")

-- ▼直接出力
PlayPartVoiceDirect("マルディサント","0023")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★マルディサント★★:そんな…
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","EA_009_0220024")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101009_sp_0003_3")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ディナタン…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0220026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","EA_009_0220028","EA_009_0220029")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
set_enable_auto_lookat(Actor004, true)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタン、心配するな<br>俺が必ずなんとかしてやるから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0220032")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0002")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★イゾルデ★★:そう大きな口を叩かないほうがいいんじゃない？<br>お前は現状をほとんど理解していないのだから
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","EA_009_0220033")

	change_face(Actor001,"Sad")

	--★★ノワール★★:それはそうだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0220034")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:けど…なにも言わないのも違うだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0220035")

-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0008")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★イゾルデ★★:…まぁ、それもそうね
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","EA_009_0220036")

-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor002,"J_Head",1.0)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:………
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_009_0220037")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
set_enable_auto_lookat(Actor004, true)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:クソッ…俺が目を離したばかりに…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0220040")

-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0007")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★イゾルデ★★:責任を感じるのは勝手だけれど、なにもかも<br>お前が背負えばいいというものでもないわ
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","EA_009_0220041")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★イゾルデ★★:彼女はもう<ruby=ゲシュタルト・シフト>ＧＳ</ruby>を果たした<br>立派な戦士なのだから
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","EA_009_0220042")

-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor001,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("マルディサント","0038")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★マルディサント★★:そうだよ。それに…<br>ンなこと言ったら、一番ふがいねぇのはアタシだ
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","EA_009_0220044")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マルディサント","0024")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★マルディサント★★:アタシがもっとちゃんと<br>ディーナのことを守ってやれりゃあ…！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","EA_009_0220045")

-- ▼直接出力
voice_play("VO_101009_sp_0010_3")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:マルディサント…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0220046")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera004)
wait_time(0.2)
keep_delay_ik_lookat(Actor004,Actor002,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
	goto Block1end

::Block1end::
-- ▼直接出力
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101017_sp_0002_1")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★マルディサント★★:ディーナ…とにかく今はゆっくり休めって<br>準備のほうはアタシがバッチリ進めとくからさ
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","EA_009_0220048")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_009_0220049")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マルディサント","0010")
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★マルディサント★★:大丈夫だって。開催までまだ時間は残ってる<br>必ずなんとかなるから
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","EA_009_0220050")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:準備…開催…？なんの話だ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0220051")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★マルディサント★★:あ、オニーサンいたんだった
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","EA_009_0220052")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いるよ。ずっと、いるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0220053")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("マルディサント","0034")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★マルディサント★★:あー、えっと…参ったな。どうすっかな<br>まだタイミングじゃねぇんだけど…
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","EA_009_0220054")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:？？？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0220055")

-- ▼直接出力
CloseTalkWindow()
PlaySE("SE_ADV_MA_01B109_11_Door")
wait_time(1.0)
on_active(Actor005)
PlayActionDirect(Actor005,"to Run")
turn_lookat_position(Actor005,CharaPos110141_02_006[1],CharaPos110141_02_006[2],CharaPos110141_02_006[3],0)
slidemove(Actor005,CharaPos110141_02_006[1],CharaPos110141_02_006[2],CharaPos110141_02_006[3],1.5)
wait_time(1.5)
setup_small_camera_start(Camera005)
PlayActionDirect(Actor005,"to Std_Loop")
turn_chara(Actor005,65,0.15)
keep_delay_ik_lookat(Actor005,Actor002,"J_Head",1.0)
lookat_delay_weight(Actor005,0.5,0.1,0.9,0.2,1.0)
lookat_delay_weight(Actor001,0.5,0.1,0.9,0.2,1.0)
set_enable_auto_lookat(Actor002, true)
set_enable_auto_lookat(Actor003, true)
set_enable_auto_lookat(Actor004, true)
wait_time(0.7)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("エレイン_005","0002")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★エレイン★★:ディナタンさん！<br>声が出なくなったって本当ですか！？
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","EA_009_0220057")

-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
set_enable_auto_lookat(Actor002, false)
set_enable_auto_lookat(Actor003, false)
set_enable_auto_lookat(Actor004, false)
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101009_sp_0016_1")
-- ▲直接出力

	--★★ノワール★★:エレイン！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0220058")


	--★★ディナタン★★:――！―――！！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_009_0220059")

	PlayAction(Actor005,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0023")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★エレイン★★:…！その様子、本当に声が――…<br>そんな――…
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","EA_009_0220060")

-- ▼直接出力
set_enable_auto_lookat(Actor005, true)
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("マルディサント","0038")
-- ▲直接出力

	--★★マルディサント★★:ディーナのことは少し休ませようと思ってる<br>で、この先のことは――
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","EA_009_0220061")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("エレイン_005","0038")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★エレイン★★:…ディナタンさんの想いを止める訳にはいかない<br>大丈夫です。私に任せてください！
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","EA_009_0220062")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_009_0220063")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0009")
-- ▲直接出力

	--★★エレイン★★:ディナタンさんが休んでる間、私がしっかり<br>コンサートの準備をやり抜いてみせます！
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","EA_009_0220064")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:～～～！！！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_009_0220065")

	PlayAction(Actor004,"to  Std_Surp")
	change_face(Actor004,"Surprise")

	--★★マルディサント★★:あ、バカ！<br>それはまだオニーサンにはヒミツで――
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","EA_009_0220066")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0028")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★エレイン★★:え
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","EA_009_0220067")

-- ▼直接出力
keep_delay_ik_lookat(Actor005,Actor001,"J_Head",0.7)
wait_time(0.6)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0220069")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera005)
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("エレイン_005","0002")
-- ▲直接出力

	--★★エレイン★★:…先輩、いたんですか
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","EA_009_0220070")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力

	--★★ノワール★★:いたよ。ずっと、いたけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0220071")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:コンサートって？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0220072")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
