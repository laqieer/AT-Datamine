

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	

	
	init_psbattleadv("201150000", "201150000")
	
	
	
	
    pbadv_setup_101009_Noir(2,true,3,34,0)
    
	pbadv_setup_101023_Clarice(0,true,2,35,0)
	
	pbadv_setup_101013_Gawain(0,true,2,34,0)
	
	
	pbadv_setup_101018_Ragnar(0,true,2,33,0)
	
	Kair  = dot_reserve_ally(401015001, 7, 34, 0)
	
	dot_set_weapon(Kair, 101010001)

	
	barbaroi    = dot_reserve_ally(401035001, 5,34, 0)
	dot_set_weapon(barbaroi, 101010001)
	barbaroi2   = dot_reserve_ally(401035001, 7,33, 0)
	dot_set_weapon(barbaroi2, 101010001)
	barbaroi3   = dot_reserve_ally(401035001, 7,35, 0)
	dot_set_weapon(barbaroi3, 101010001)
	
	
	change_time_and_weather(1,1)
	
	
	
	
	setup_complete_unit()
	
	dot_unit_dir(Kair, 2)
	dot_unit_dir(barbaroi, 2)
	dot_unit_dir(barbaroi2, 2)
	dot_unit_dir(barbaroi3, 2)
	
	dot_disp_weapon(Kair, false)
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(30.0, 0.0)

	
	
	move_camera(4, 34, 0.0)
	
	Ef_Zoon=load_particle("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	Ef_Zoon2=load_particle("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	Ef_Zoon3=load_particle("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	Ef_Zoon4=load_particle("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	Ef_Zoon5=load_particle("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	Ef_Zoon6=load_particle("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	Ef_Zoon7=load_particle("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	Ef_Zoon8=load_particle("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	Ef_Zoon9=load_particle("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	Ef_Zoon10=load_particle("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	Ef_Zoon11=load_particle("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	Ef_Zoon12=load_particle("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	Ef_Zoon13=load_particle("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	Ef_Zoon14=load_particle("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	Ef_Zoon15=load_particle("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	Ef_Zoon16=load_particle("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	Ef_Zoon17=load_particle("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	Ef_Zoon18=load_particle("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	Ef_Zoon19=load_particle("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	Ef_Zoon20=load_particle("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	Ef_Zoon21=load_particle("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)

	load_sound("BGM_Battle_Candlelight")
	
end

function Play()
	fadein(0)
	Play_start(true)

	-- @ログレス兵？A	白い花束サマサマだな<ruby=ガキ>幸運</ruby>が自分から俺に突っ込んできやがった	
	open_speech_window("NPCNAME_0390",nil , nil)
	message("EA_007_0320006")
	close_speech_window()

				--//「幸運」ルビ「ガキ」
	-- @カイル	はなせ！！はなせよ！！	
	open_speech_window("NPCNAME_0386",nil , nil)
	message("EA_007_0320008")
	close_speech_window()

	-- @ログレス兵？B	動くなよ学生ども動けばこのガキがどうなるかわからねえぞ	
	open_speech_window("NPCNAME_0391",nil , nil)
	message("EA_007_0320009")
	close_speech_window()

	-- @ログレス兵？A	俺たちはなにも喧嘩したいわけじゃねえこのガキさえ手に入ればいいんだ	
	open_speech_window("NPCNAME_0390",nil , nil)
	message("EA_007_0320010")
	close_speech_window()

	-- @ログレス兵？B	けどせっかくだ、これを機に円卓の騎士の首をもらうのも悪くはねえかあ	
	open_speech_window("NPCNAME_0391",nil , nil)
	message("EA_007_0320011")
	--close_speech_window()

    -- 選択1回目
    EA_007_032_select1()
 
    open_select_window_tag(Noir2, "Normal", "EA_007_0320014", "EA_007_0320015")  -- 選択肢表示
 
    if is_select(1) then            -- 1番目の選択肢を選んだ場合
        EA_007_032_select1_1()
 
    elseif is_select(2) then        -- 2番目の選択肢を選んだ場合
        EA_007_032_select1_2()
 
    end
   EA_007_032_end()
 
end
 
function EA_007_032_select1()
 
end
 
function EA_007_032_select1_1()
 
-- ---選択肢1

	-- @ノワール	…くっ、逃がすしか、ないのか…？	
	change_face(Noir2, "Sad")
	open_speech_window("PLAYERNAME_NOIR",Noir2 , nil)
	message("EA_007_0320018")
	--close_speech_window()

	-- @ノワール	いや、だめだ…逃がしたらカイルの命の保証はない	
	--open_speech_window("PLAYERNAME_NOIR",Noir2 , nil)
	message("EA_007_0320019")
	close_speech_window()

	-- @ラグネル	でも敵に手を出せばカイルくんが危ないし…！	
	change_face(Ragnar, "Sad")
	open_speech_window("CHRNAME_RAGNAR",Ragnar , nil)
	message("EA_007_0320020")
	close_speech_window()
 
      -- ---選択肢1ここまで
end
 
 
function EA_007_032_select1_2()
 
 
 dot_change_anim(dotNoir2,12)
--//分岐2
				--//2を選択
	-- @ノワール	敵を、なんとか倒せば──	
	change_face(Noir2, "Anger")
	open_speech_window("PLAYERNAME_NOIR",Noir2 , nil)
	message("EA_007_0320023")
	close_speech_window()

	-- @ガウェイン	この距離じゃあ手が出せねえよ…！	
	change_face(Gawain, "Anger")
	open_speech_window("CHRNAME_GAWAIN",Gawain , nil)
	PlayPartVoiceDirect("ガウェイン","0017")
	message("EA_007_0320024")
	--close_speech_window()

	-- @ガウェイン	敵を倒す前にカイルがやられちまう…	
	--open_speech_window("CHRNAME_GAWAIN",Gawain , nil)
	message("EA_007_0320025")
	close_speech_window()
 
    -- ---選択肢2ここまで
end
 
 
function EA_007_032_end()
				
				
				dot_change_anim(dotNoir2,0)

				--//合流
	-- @ノワール	…だめだ、選べない………！	]
	change_face(Noir2, "Sad")
	open_speech_window("PLAYERNAME_NOIR",Noir2 , nil)
	PlayPartVoiceDirect("ノワール","0021")
	message("EA_007_0320027")
	close_speech_window()
	
	

	-- @クラリス	………みなさん、ご安心を	
	change_face(Clarice, "Normal")
	open_speech_window("CHRNAME_CLARICE",Clarice , nil)
	PlayPartVoiceDirect("クラリス","0007")
	message("EA_007_0320028")
	close_speech_window()

				--//ここからバトルマップへ。
	-- @ノワール	クラリス…？「ご安心を」って、どういうことだ？	
	open_speech_window("PLAYERNAME_NOIR",Noir2 , nil)
	PlayPartVoiceDirect("ノワール","0028")
	message("EA_007_0320030")
	close_speech_window()
	
	dot_move_unit_seq(dotClarice,3,35)

	-- @クラリス	お耳を拝借	
	change_face(Clarice, "Normal")
	open_speech_window("CHRNAME_CLARICE",Clarice , nil)
	voice_play("VO_101023_sp_0001_1")
	message("EA_007_0320031")
	--close_speech_window()
	
	move_camera(37, 34, 1.5)
	
	on_active(Ef_Zoon)
	on_active(Ef_Zoon2)
	on_active(Ef_Zoon3)
	on_active(Ef_Zoon4)
	on_active(Ef_Zoon5)
	on_active(Ef_Zoon6)
	on_active(Ef_Zoon7)
	on_active(Ef_Zoon8)
	on_active(Ef_Zoon9)
	on_active(Ef_Zoon10)
	on_active(Ef_Zoon11)
	on_active(Ef_Zoon12)
	on_active(Ef_Zoon13)
	on_active(Ef_Zoon14)
	on_active(Ef_Zoon15)
	on_active(Ef_Zoon16)
	on_active(Ef_Zoon17)
	on_active(Ef_Zoon18)
	on_active(Ef_Zoon19)
	on_active(Ef_Zoon20)
	on_active(Ef_Zoon21)
	
	
	local gridpos=get_grid_position(40,32)
	set_pos(Ef_Zoon21,gridpos)
	play_particle(Ef_Zoon21)
	
	local gridpos=get_grid_position(39,32)
	set_pos(Ef_Zoon2,gridpos)
	play_particle(Ef_Zoon2)
	
	local gridpos=get_grid_position(38,32)
	set_pos(Ef_Zoon3,gridpos)
	play_particle(Ef_Zoon3)
	
	local gridpos=get_grid_position(37,32)
	set_pos(Ef_Zoon4,gridpos)
	play_particle(Ef_Zoon4)
	
	
	local gridpos=get_grid_position(40,33)
	set_pos(Ef_Zoon5,gridpos)
	play_particle(Ef_Zoon5)
	
	local gridpos=get_grid_position(39,33)
	set_pos(Ef_Zoon6,gridpos)
	play_particle(Ef_Zoon6)
	
	local gridpos=get_grid_position(38,33)
	set_pos(Ef_Zoon7,gridpos)
	play_particle(Ef_Zoon7)
	
	local gridpos=get_grid_position(37,33)
	set_pos(Ef_Zoon8,gridpos)
	play_particle(Ef_Zoon8)
	
	
	local gridpos=get_grid_position(40,34)
	set_pos(Ef_Zoon9,gridpos)
	play_particle(Ef_Zoon9)
	
	
	local gridpos=get_grid_position(39,34)
	set_pos(Ef_Zoon10,gridpos)
	play_particle(Ef_Zoon10)
	
	local gridpos=get_grid_position(38,34)
	set_pos(Ef_Zoon11,gridpos)
	play_particle(Ef_Zoon11)
	
	local gridpos=get_grid_position(37,34)
	set_pos(Ef_Zoon12,gridpos)
	play_particle(Ef_Zoon12)
	
	
	local gridpos=get_grid_position(40,35)
	set_pos(Ef_Zoon13,gridpos)
	play_particle(Ef_Zoon13)
	
	local gridpos=get_grid_position(39,35)
	set_pos(Ef_Zoon14,gridpos)
	play_particle(Ef_Zoon14)
	
	local gridpos=get_grid_position(38,35)
	set_pos(Ef_Zoon15,gridpos)
	play_particle(Ef_Zoon15)
	
	local gridpos=get_grid_position(37,35)
	set_pos(Ef_Zoon16,gridpos)
	play_particle(Ef_Zoon16)
	
	
	local gridpos=get_grid_position(40,36)
	set_pos(Ef_Zoon17,gridpos)
	play_particle(Ef_Zoon17)
	
	local gridpos=get_grid_position(39,36)
	set_pos(Ef_Zoon18,gridpos)
	play_particle(Ef_Zoon18)
	
	local gridpos=get_grid_position(38,36)
	set_pos(Ef_Zoon19,gridpos)
	play_particle(Ef_Zoon19)
	
	
	local gridpos=get_grid_position(37,36)
	set_pos(Ef_Zoon,gridpos)
	play_particle(Ef_Zoon20)
	
	
	
	wait_time(1.5)
	
	

				--//こそこそ話
	-- @クラリス	敵の攻撃に耐えつつ『あのエリア』に向かってください	
	--open_speech_window("CHRNAME_CLARICE2",Clarice1 , nil)
	message("EA_007_0320033")
	--close_speech_window()
	
	

	-- @クラリス	そうすれば──	
	--open_speech_window("CHRNAME_CLARICE2",Clarice1 , nil)
	message("EA_007_0320034")
	close_speech_window()

				--//バトルマップ上で特定地点がマーキングされるなど、わかりやすい演出が入ると望ましいです。
				--//提出済プロットより、このあと開始のバトル１は以下ギミックでお願いいたします。
				--//＝＝＝＝＝＝＝＝＝
				--//バトルチームさんに相談：敵を追い込む、というギミックは難しそう。可能なギミックに合わせてセリフを要調整。ただし、特定エリアに誰かが入るとモルドレッドが登場、という流れは変えない。例：特定エリアに助っ人がいるから、誰かが報せに行く
				--//↑上記FBについて調整。プレイキャラが敵の攻撃に耐えつつ、特定エリアまで到達することでクリアとする。（モルドレッドが待機している箇所まで敵をおびき寄せる流れ）
				--//※敵に攻撃したらNG、もしくは敵を倒したらNGなどの条件があるとより良い
				--//併せて前後の会話も調整。]
				
	move_camera(4, 34, 2.0)
	wait_time(2.0)
				
	-- @ログレス兵？A	なにコソコソしゃべっていやがるこのガキがどうなってもいいのかぁ？	
	open_speech_window("NPCNAME_0390",nil , nil)
	message("EA_007_0320042")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_MidFade")
	-- @クラリス	…──にこ	
	change_face(Clarice, "Laugh")
	open_speech_window("CHRNAME_CLARICE",Clarice , nil)
	message("EA_007_0320043")
	close_speech_window()

	-- @ログレス兵？B	なっ、なんだ	
	open_speech_window("NPCNAME_0391",nil , nil)
	message("EA_007_0320044")
	close_speech_window()

	bgm_play("BGM_Battle_Candlelight")
	-- @クラリス	ご自身のお立場がわかっていないようですね	
	open_speech_window("CHRNAME_CLARICE",Clarice , nil)
	PlayPartVoiceDirect("クラリス","0025")
	message("EA_007_0320045")
	--close_speech_window()

	-- @クラリス	その子の命を奪えばわたしたちが大人しくする理由はなくなります	
	--open_speech_window("", , nil)
	message("EA_007_0320046")
	close_speech_window()
	
	dot_move_unit_seq(barbaroi ,6,34)
	wait_seq()
	dot_unit_dir(barbaroi, 2)

				--//暴漢あとずさる。
	-- @ログレス兵？B	…！？く、来るな…！！だったらその前にてめえらをヤッてやるッ！	
	open_speech_window("NPCNAME_0391",nil , nil)
	message("EA_007_0320048")
	close_speech_window()

				--//挑発。指定エリアまで追って来させるための
	-- @クラリス	あなたたちの命を握っているのは、コチラですよ	
	change_face(Clarice , "Anger")
	open_speech_window("CHRNAME_CLARICE",Clarice , nil)
	message("EA_007_0320050")
	close_speech_window()

	-- @ノワール	（…やるな。敵を挑発してる俺たちを追って来させるために）
	change_face(Noir2, "Laugh")	
	open_mind_window("PLAYERNAME_NOIR",Noir2 , nil)
	message("EA_007_0320051")
	close_mind_window()

	-- @クラリス	不幸にも、ね	
	change_face(Clarice, "Smile")
	open_speech_window("CHRNAME_CLARICE",Clarice , nil)
	PlayPartVoiceDirect("クラリス","0010")
	message("EA_007_0320052")
	close_speech_window()




	
	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
    pbadv_setup_101009_Noir_preload(2,true,3,34,0)
	pbadv_setup_101023_Clarice_preload(0,true,2,35,0)
	pbadv_setup_101013_Gawain_preload(0,true,2,34,0)
	pbadv_setup_101018_Ragnar_preload(0,true,2,33,0)
	load_particle_preload("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	load_particle_preload("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	load_particle_preload("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	load_particle_preload("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	load_particle_preload("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	load_particle_preload("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	load_particle_preload("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	load_particle_preload("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	load_particle_preload("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	load_particle_preload("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	load_particle_preload("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	load_particle_preload("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	load_particle_preload("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	load_particle_preload("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	load_particle_preload("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	load_particle_preload("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	load_particle_preload("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	load_particle_preload("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	load_particle_preload("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	load_particle_preload("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	load_particle_preload("content_effect3d_common_common","Ef_C_Cmn_Destination_Lop",false,true)
	preload_sound("BGM_Battle_Candlelight")
end
