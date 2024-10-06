-- このluaスクリプトは、EA_002_021.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",129,CharaPos110191_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_003)
	Camera003 = SetTemplate("Actor003",0,CharaPos110191_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_001)
	Camera004 = SetTemplate("Actor004",270,CharaPos110191_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_005)
	Camera005 = SetTemplate("Actor005",270,CharaPos110191_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_006)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
set_common_look_at(Actor001,Actor002,1.25)
set_common_look_at(Actor002,Actor001,1.25)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{4.075, 0, -28.504})
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
set_pos(Actor004,{18.27, 0, -27})
set_pos(Actor005,{18.27, 0, -26.5})
slidemove(Actor004,0, 0, -27,11.0)
slidemove(Actor005,0, 0, -26.5,11.0)
PlayActionDirect(Actor004,"to Wlk")
PlayActionDirect(Actor005,"to Wlk")
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor004,Actor005,1.25)
set_common_look_at(Actor005,Actor004,1.25)
lookat_delay_weight(Actor004,0.7,0.04,0.75,0.3,0.7)
keep_ik_lookat(Actor004,Actor005,"J_Head")
lookat_delay_weight(Actor004,0.7,0.04,0.75,0.3,0.7)
keep_ik_lookat(Actor005,Actor004,"J_Head")
-- ▲直接出力
-- ▼直接出力
CameraEx1=set_camera({3.55, 1.82983, -26.37036,   10.04332, 86.89808, 0.06066,   27.83267})
set_camera_lookat(CameraEx1,13.26, 1.65, -25.302)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
lookat_delay_weight(Actor003,0.8,0.04,0.8,0.2,0.7)
keep_ik_lookat(Actor003,Actor005,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Talk")
wait_time(1.0)
play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
wait_time(1.0)
on_camera(CameraEx1)
slidemove(CameraEx1,2.833, 1.448, -28.72,3.5,3)
wait_time(2.0)
play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
wait_time(1.0)
play_head_motion(Actor005, "No", 0.3, 1.0, false)
lookat_delay_weight_reset(Actor003,0.3)
wait_time(1.0)
setup_small_camera_end(Camera002)
SkipOffsetCamera(Camera002)
Hide(Actor005)
Hide(Actor004)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力

	--★★イゾルデ★★:『薬は嘘をつかない』と
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_021002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★イゾルデ★★:そう教えてくれた人自身が重病だなんて<br>笑うわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_021003")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:その人が──…イゾルデの薬学の師？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_021004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:久方ぶりに便りが来てね<br>会いに行ってみれば手遅れなほどで
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_021006")

	change_face(Actor002,"Laugh")

	--★★イゾルデ★★:口はうるさいほど動いてたから…あの人<br>ふふ。変わったのは体調だけ、残酷ね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_021008")

-- ▼直接出力
PlayPartVoice("イゾルデ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★イゾルデ★★:狂忘症とかそういった類のものではないの<br>ただの病魔、ただの──…
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_021009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★イゾルデ★★:…<dot>相応しい薬</dot>さえあれば救えるのよ、あの人を<br>目処はついているわ。けれどね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_021011")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor003,"to Wlk")
wait_time(0.03)
setup_small_camera_start(RndCamera006)
set_pos(Actor003,{CharaPos110191_01_001[1]-1.5,CharaPos110191_01_001[2],CharaPos110191_01_001[3]-0.5})
turn_lookat_position(Actor003,CharaPos110191_01_001[1],CharaPos110191_01_001[2],CharaPos110191_01_001[3],0)
slidemove(Actor003,CharaPos110191_01_001[1],CharaPos110191_01_001[2],CharaPos110191_01_001[3],1.0)
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
PlayActionDirect(Actor003,"to Std_Loop")
set_common_look_at(Actor003,Actor002,0.8)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★クレア★★:商人マルイルに聞いても<br><ruby=コーンウォール>薬草の群生地</ruby>に行っても見つからない
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_002_021013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "納得")
-- ▲直接出力

	--★★クレア★★:もうこうなれば神頼み…<br>妥当な流れね
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_002_021014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力

	--★★ノワール★★:<ruby=リアムさん>大聖堂の司祭</ruby>が…どうして知ってるんだ？<br>そんな特別な薬のことを
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_021015")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:人々の懺悔を聞くなかで知ったことか<br>ツテがあったのか…まぁ色々あるみたいね彼も
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_021016")

	change_face(Actor001,"Normal")

	--★★ノワール★★:だけどその薬の所在を話そうとしない…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_021101")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★イゾルデ★★:人々へ救いの手を差し伸べるのが<br>神の務めだと信じていたのだけれどね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_021018")

-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:しかし司祭は賭けに乗ってくれた<br>あとは賭けの対象となる…<ruby=ノワール>あなた</ruby>次第
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_002_021019")

	open_select_window_tag(Actor001,"Normal","EA_002_021021","EA_002_021022")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:賭けの内容がわからないことには
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_021024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クレア★★:事前にそれを伝えたところで<br>あなたの返事が変わるとは思えない
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_002_021025")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:か、変わるだろ…要件によって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_021026")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★クレア★★:ＹＥＳを言ってもらえるであろうことは<br>想像に難くない。あなたの性格上ね
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_002_021027")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:俺にできることがあるならやるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_021029")

-- ▼直接出力
PlayPartVoice("イゾルデ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★イゾルデ★★:…賭けの詳細すら<br>聞いていないのに？
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_021030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺にできることを用意してくれてるんだろ？<br>きっと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_021031")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★イゾルデ★★:………まあ、そうかもしれないわね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_021033")

	goto Block1end

::Block1end::
	change_face(Actor003,"Normal")

	--★★クレア★★:賭けの内容は簡単
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_002_021035")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:『うきうきプレミアム感謝デーランチ』争奪<br>がんばれノワールバトル、だっけ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_021036")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:今日の昼、城下町のマーケットの屋台に<br>『うきうきプレミアム感謝デーランチ』が並ぶ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_002_021037")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0030")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor001,"Surprise")

	--★★ノワール★★:まず、なんなんだ…！？<br>『うきうきプレミアム感謝デーランチ』って
	Talk(Actor001,"CHRNAME_NOIR","speech","N","EA_002_021038")

	close_cutin()
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力
	open_cutin(2,1)
	on_cutin(1,Actor002,"Laugh")

	--★★イゾルデ★★:年に一度しか作られないレアで特別なランチよ<br>我が校のコック長考案でね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","N","EA_002_021039")

	on_cutin(1,Actor002,"Laugh")

	--★★イゾルデ★★:兵や民への感謝を込めたものらしいわ<br>真夏の炎天下で焼き上げる具材は絶品のひとこと
	Talk(Actor002,"CHRNAME_ISOLDE","speech","N","EA_002_021040")

-- ▼直接出力
PlayPartVoice("クレア", "肯定3")
-- ▲直接出力
	on_cutin(2,Actor003,"Smile")

	--★★クレア★★:街中でリトルバカンス気分<br>遠出もままならない市井の人は大歓喜
	Talk(Actor003,"CHRNAME_CLARE","speech","N","EA_002_021041")


	--★★クレア★★:先着順で、ありつけるのは限られた人数のみ<br>だから毎年ごった返してしょうがない
	Talk(Actor003,"CHRNAME_CLARE","speech","N","EA_002_021042")

	close_cutin()
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★イゾルデ★★:さらに今年はその破格で極上の一食を<br><ruby=ガレス>新進のコック</ruby>が引き継いだ。誰もが期待大よ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_021043")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:『うきうきプレミアム感謝デーランチ』争奪<br>がんばれノワールバトルって──…まさか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_021044")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:お前がランチにありつければ、賭けは私の勝ち<br>ランチが売り切れれば…その時点で私の負けよ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_021045")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("イゾルデ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★イゾルデ★★:…ただノワール、この賭け…お前に利益はないわ<br>それでも──
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_021047")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:イゾルデ<br><ruby=マルディサント>妹の友達</ruby>を診てくれたことあったよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_021048")

-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★イゾルデ★★:？<br>そんなことも、あったわね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_021050")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:その知識をイゾルデに与えてくれた人なら<br>俺にとっても恩人だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_021051")

	change_face(Actor002,"Shy")

	--★★イゾルデ★★:………そう
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_021053")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:あと、極上で破格のランチは気になるし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_021054")

-- ▼直接出力
PlayPartVoice("イゾルデ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★イゾルデ★★:…ふふ<br>そういうことにしてくれるのね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_021055")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力

	--★★クレア★★:ランチまで辿り着ければ<br>そのお代ぐらいは出してあげる
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_002_021056")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
set_enable_auto_lookat(Actor002, false)
wait_time(0.6)
lookat_delay_weight(Actor002, 1.0, 0.5, 1.0, 0.2,0.5)
keep_ik_lookat(Actor002,Actor001,"J_Head")
wait_time(1.3)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0009")
-- ▲直接出力

	--★★イゾルデ★★:お前に<br>かかってるわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_021057")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	InitializeLoad_Preload()
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
