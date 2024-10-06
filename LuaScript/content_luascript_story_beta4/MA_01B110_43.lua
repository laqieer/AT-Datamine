-- このluaスクリプトは、MA_01B110_43.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110161_02","110161_02_h")
Include("content_adv_advsmall_110161_02","Template110161_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-175,CharaPos110161_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110161_02,CameraPos110161_02_003)
	Camera002 = SetTemplate("Actor002",170,CharaPos110161_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110161_02,CameraPos110161_02_002)
	Camera003 = SetTemplate("Actor003",20,CharaPos110161_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110161_02,CameraPos110161_02_005)
	Camera004 = SetTemplate("Actor004",40,CharaPos110161_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110161_02,CameraPos110161_02_006)
	InitializeTemplateRandomCamera110161_02()
	InitializeTemplate110161_02()
-- ▼直接出力
DontCameraOffset(Actor003)
chair_01 = get_object("geo_chair_14")
set_pos(chair_01, {1.05,0,3.13})
set_rot(chair_01,{0,0,0})
chair_02 = get_object("geo_chair_09")
set_pos(chair_02, {2.8,0,2.1})
set_rot(chair_02,{0,30,0})
prop001=setup_prop_object(10101017)
prop001_offset={0,0,0,0,0,0}
on_parent(prop001,Actor003,"Loc_weapon_constrint_R", prop001_offset)
on_active(prop001)
set_pos(Actor003,{2.3,0.3,1.4})
set_animationcontroller(Actor003,"Chr_004_01_SitController","to Sit01_Loop")
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to hurpplay_loop")
Hide(Actor001)
Hide(Actor002)
se_play("SE_ADV_CO_101014_1002_Harp_Arp")
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor004,Actor003)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115164)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Talk")
 --PlayPartVoice("イゾルデ", "挨拶")
-- ▲直接出力

	--★★イゾルデ★★:音が粒だっているわ
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01B110_430002")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
 --PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力

	--★★トリスタン★★:そうかな
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01B110_430003")

-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
 --PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力

	--★★イゾルデ★★:なにか心境の変化があった？<br>悪いほうか…あるいは──
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01B110_430004")

	PlayAction(Actor003,"to hurp_loop")
-- ▼直接出力
setup_small_camera_start(Camera003)
se_play("SE_ADV_Loop_Stop")
Appear(Actor001)
Appear(Actor002)
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★トリスタン★★:…どちらにせよ<br>キミたちにタダで聞かせる曲はないよ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01B110_430006")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
set_enable_auto_lookat_all(false)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:………ガラハッドは<br>聞かせたいことがあってきたんだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_430008")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("トリスタン", "否定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★トリスタン★★:興味ないなあ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01B110_430009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ガラハッド★★:トリスタン<br>お前の言う通りだったかもしれない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_430010")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:『家族』という言葉は恐らく<br>万能な言葉でも、解決手段でもない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_430011")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★トリスタン★★:そうだね、そう思うよ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01B110_430012")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:だからガラハッドは家族を学ぶ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_430013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:必要ならば償わせる<br>誤った道を歩んでいるのなら引き留める
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_430014")


	--★★ガラハッド★★:ガラハッド自身が未熟なのだとすれば<br>学び直して改める
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_430015")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera003)
 --PlayPartVoice("トリスタン", "納得")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★トリスタン★★:まだ家族を信じ続けるんだ<br>ずいぶんと辛抱強いね
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01B110_430016")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
setup_small_camera_start(Camera002)
set_animationcontroller(Actor003,"Chr_004_01_StdController","to Std_Loop")
Camera003=setup_small_camera_resetting(Actor003,CharaPos005,CameraPos005)
set_rot(Actor003,{0,35,0})
 lookat_delay_weight_reset(Actor003,1)
set_enable_auto_lookat(Actor003,false)
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_No")
off_parent(prop001)
set_pos(prop001,{2.75,0.81,2.1})
set_rot(prop001,{0,-15,-30})
-- ▲直接出力

	--★★ガラハッド★★:家族のいまが<br>信じるに値するかはわからずとも──
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_430017")


	--★★ガラハッド★★:家族と呼び合えた…その過去は本物だ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_430018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:昔の思い出だけは<br>変えようもない絆だから
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_430020")

-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
 --PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力

	--★★トリスタン★★:………勝手にすれば。がんばって
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01B110_430022")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:トリスタン…もうガラハッドを<br>目の敵にしなくてもいいんじゃないのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_430023")

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("トリスタン", "激怒")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★トリスタン★★:ボクは<ruby=ルーシャス>ローマ</ruby>を見通し切れなかったんだよ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01B110_430024")

-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
turn_chara(Actor003,0,0.5)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★トリスタン★★:ノワール<br>キミの本質さえいまだにわかりそうにない
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01B110_430026")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★トリスタン★★:見誤ることはもう許されないんだよ<br>ボク自身、自分を許すことはできないね
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01B110_430027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:………トリスタン
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_430028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Sad01")
	change_face(Actor004,"Sad")

	--★★イゾルデ★★:…だから<br>疑い続けようっていうのね
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01B110_430029")


	--★★イゾルデ★★:他者も、自分自身さえも
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01B110_430030")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★トリスタン★★:そうすれば少なくとも<br>裏切られた気持ちにはならないさ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01B110_430031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:………じゃあどうして<br>ガラハッドの独走を許したんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_430032")


	--★★ノワール★★:見逃すようなミスはしないだろう？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_430034")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★イゾルデ★★:見事なスピードで飛び出したから<br>捕らえきれなかったのかしら？
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01B110_430035")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:…ガラハッドを、信じてくれたのか？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_430036")

	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Normal")

	--★★トリスタン★★:まさか<br>試してみただけさ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01B110_430037")


	--★★イゾルデ★★:試した結果は？
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01B110_430038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★トリスタン★★:信頼性ゼロ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01B110_430039")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "激怒")
-- ▲直接出力

	--★★ガラハッド★★:ええっ！？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_430040")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★トリスタン★★:結局ひとりでは何もできず<br>円卓の騎士の手を借りてやっとの帰還
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01B110_430041")


	--★★トリスタン★★:大騒ぎしたにもかかわらず<br>聖杯を見つけてくることもできず
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01B110_430042")

-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Sad02")
 --PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★トリスタン★★:またも不穏分子ふたりも連れ帰って<br>心労は増えるばかりだ、頭痛は続くよ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01B110_430043")

	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("イゾルデ", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★イゾルデ★★:暇しなくっていいわね
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01B110_430044")

-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★トリスタン★★:けど、まぁ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01B110_430045")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
change_face(Actor004,"Normal")
-- ▲直接出力

	--★★トリスタン★★:…「昔の思い出だけは変えようもない」<br>って本音は…信じたい言葉かな。少し
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01B110_430046")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:そう、だろう？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_430047")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定3")
-- ▲直接出力

	--★★トリスタン★★:信じたほうが<br>楽になれそうだ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01B110_430048")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:じゃあこれから監視は──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_430049")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("トリスタン", "激怒")
-- ▲直接出力

	--★★トリスタン★★:続けるさ<br>やめるわけないでしょ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01B110_430051")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
set_common_look_at(Actor004,Actor002)
 --PlayPartVoice("ガラハッド", "激怒")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor002,"Sad")

	--★★ガラハッド★★:ええ～、もういいだろう！<br>ガラハッドは潔白だぞ！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","N","MA_01B110_430052")

	close_cutin()
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor002,true)
 --PlayPartVoice("イゾルデ", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★イゾルデ★★:お前、わかってないわね<br>だからこそでしょう？
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01B110_430054")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力

	--★★トリスタン★★:信じた相手が本当に<br>頼れるヤツなのかどうか
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01B110_430056")

	PlayAction(Actor004,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力

	--★★イゾルデ★★:見届けないと<br>心配で夜も眠れないわね
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01B110_430057")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★イゾルデ★★:遠くから応援してるわ<br>距離が近いスキンシップは遠慮したいの
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01B110_430058")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★トリスタン★★:その背中<br>見守っててあげるよ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01B110_430060")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10101017)
prop001_offset={0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_area_scene_preload(115164)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110161_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
